#include "Server.h"
#include <exception>
#include <iostream>
#include <string>

#define MESSAGE_LEN 100
#define LOGIN_CODE 200
#define IP_SIZE 16 // 12 numbers, 3 dots, 1 for null char
#define MIN_NUM_OF_CLIENTS 2 //minimum number of client to open a sender thread
#define NAME_LEN_FIELD 2
#define MESSAGE_LEN_FIELD 5
#define LISTEN_PORT 5050
#define HELLO_LEN 5

using std::cout;
using std::endl;
using std::flush;
using std::cerr;

Server::Server()
{

	// this server use TCP. that why SOCK_STREAM & IPPROTO_TCP
	// if the server use UDP we will use: SOCK_DGRAM & IPPROTO_UDP
	m_serverSocket = socket(AF_INET, SOCK_STREAM, IPPROTO_TCP);

	if (m_serverSocket == INVALID_SOCKET) {
		throw std::exception(__FUNCTION__ " - socket");
	}
}

Server::~Server()
{
	try
	{
		// the only use of the destructor should be for freeing 
		// resources that was allocated in the constructor
		closesocket(m_serverSocket);
	}
	catch (...) {}
}

void Server::run()
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
		accept();
	}
	
}

void Server::accept()
{
	// notice that we step out to the global namespace
	// for the resolution of the function accept

	// this accepts the client and create a specific socket from server to this client
	SOCKET client_socket = ::accept(m_serverSocket, NULL, NULL);

	if (client_socket == INVALID_SOCKET) {
		throw std::exception(__FUNCTION__);
	}

	std::cout << "Client accepted. Server and client can speak" << std::endl;

	std::cout << "Cerating thread..." << std::endl;
	//creating a thread for the client and detaching it from the function
	std::thread t(&Server::handleClient, this, client_socket);
	t.detach();
}

void Server::handleClient(SOCKET clientSocket)
{
	std::cout << "Comms with the client..." << std::endl;

	try {
		Helper::sendData(clientSocket, "Hello");
		auto retVal = Helper::getStringPartFromSocket(clientSocket, HELLO_LEN);
		std::cout << retVal << std::endl;
	}
	catch (const std::exception& e) {
		std::cout << e.what() << std::endl;
	}
	
}

