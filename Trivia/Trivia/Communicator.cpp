#include "Communicator.h"
#include <iostream>
#include <ctime>
#include "Codes.h"
#include "JsonResponsePacketSerializer.h"
#include "JsonRequestPacketDeserializer.h"
#include "IDataBase.h"
#include "SqliteDataBase.h"
#include "LoginManager.h"
#define LISTEN_PORT 5050
#define HELLO_LEN 5
#define LEN_SIZE 4
#define CODE_LEN 1
#define SUCCESS 1

IDataBase* gDataBase = new SqliteDataBase();
LoginManager gLoginManager(gDataBase);
RequestHandlerFactory gHandlerFactory;

Communicator::Communicator()
{
	//setting the socket to communicate with the clients
	m_serverSocket = socket(AF_INET, SOCK_STREAM, IPPROTO_TCP);

	//throws an error if the socket is invalid
	if (m_serverSocket == INVALID_SOCKET) {
		throw std::exception(__FUNCTION__ " - socket");
	}
}

Communicator::~Communicator()
{
	//deletes the allocated handlers 
	for (const auto& client : m_clients) {
		delete client.second;
	}

	try
	{
		// the only use of the destructor should be for freeing 
		// resources that was allocated in the constructor
		closesocket(m_serverSocket);
	}
	catch (...) {}
}

void Communicator::startHandleRequests()
{
	bindAndListen();
}

void Communicator::bindAndListen()
{
	struct sockaddr_in sa = { 0 };

	sa.sin_port = htons(LISTEN_PORT); // port that server will listen for
	sa.sin_family = AF_INET;   // must be AF_INET
	sa.sin_addr.s_addr = INADDR_ANY;    // when there are few ip's for the machine. We will use always "INADDR_ANY"

	// again stepping out to the global namespace
	// Connects between the socket and the configuration (port and etc..)
	if (bind(m_serverSocket, (struct sockaddr*)&sa, sizeof(sa)) == SOCKET_ERROR)
		throw std::exception(__FUNCTION__ " - bind");

	// Start listening for incoming requests of clients
	if (listen(m_serverSocket, SOMAXCONN) == SOCKET_ERROR)
		throw std::exception(__FUNCTION__ " - listen");
	std::cout << "Listening on port " << LISTEN_PORT << std::endl;

	while (true)
	{
		// the main thread is only accepting clients 
		// and add then to the list of handlers
		std::cout << "Waiting for client connection request" << std::endl;
		acceptConnection();
	}
}

void Communicator::acceptConnection()
{
	// notice that we step out to the global namespace
	// for the resolution of the function accept

	// this accepts the client and create a specific socket from server to this client
	SOCKET client_socket = ::accept(m_serverSocket, NULL, NULL);

	if (client_socket == INVALID_SOCKET) {
		throw std::exception(__FUNCTION__);
	}

	std::cout << "Client accepted. Server and client can speak" << std::endl;

	std::cout << "Creating thread..." << std::endl;
	//creating a thread for the client and detaching it from the function
	IRequestHandler* reqHandler = new LoginRequestHandler(gLoginManager, gHandlerFactory);
	m_clients.insert(std::make_pair(client_socket, reqHandler));
	std::thread t(&Communicator::handleNewClient, this, client_socket);
	t.detach();
	
}

void Communicator::handleNewClient(SOCKET clientSocket)
{
	std::cout << "Comms with the client..." << std::endl;

	try {
		// sending and reciving hello message
		Helper::sendData(clientSocket, "Hello");
		auto retVal = Helper::getStringPartFromSocket(clientSocket, HELLO_LEN);
		std::cout << retVal << std::endl;

		// splitting the request of the client
		RequestInfo clientRequest;
		clientRequest.id = Helper::getStringPartFromSocket(clientSocket, CODE_LEN)[0];
		clientRequest.receivalTime = time(NULL);
		auto reqDataLen = Helper::getIntPartFromSocket(clientSocket, LEN_SIZE);
		auto jsonData = Helper::getStringPartFromSocket(clientSocket, reqDataLen);
		for (const auto ch : jsonData) {
			clientRequest.buffer.push_back(ch);
		}

		LoginRequest req;
		if (clientRequest.id == LOGIN_CODE) {
			req = JsonRequestPacketDeserializer::deserializeLoginRequest(clientRequest.buffer);
			
			//TO FILL - handle login request in the program

			LoginResponse resStruct(SUCCESS);
			
			const auto res = JsonResponsePacketSerializer::serializeResponse(resStruct);
			std::string resInString;

			for (const auto ch : res) {
				resInString += ch;
			}

			Helper::sendData(clientSocket, resInString);

		}
		else if (clientRequest.id == SIGNUP_CODE) {
			req = JsonRequestPacketDeserializer::deserializeSignupRequest(clientRequest.buffer);
			
			//TO FILL - handle signup request in the program 

			SignupResponse resStruct(SUCCESS);

			const auto res = JsonResponsePacketSerializer::serializeResponse(resStruct);
			std::string resInString;

			for (const auto ch : res) {
				resInString += ch;
			}

			Helper::sendData(clientSocket, resInString);
		}

	}
	catch (const std::exception& e) {
		std::cout << e.what() << std::endl;
	}

}

