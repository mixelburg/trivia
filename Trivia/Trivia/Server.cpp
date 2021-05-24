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

Server::Server(): m_communicator(m_handlerFactory, *m_database)
{
	m_database = new SqliteDataBase();
	LoginManager loginManager(m_database);
	RoomManager roomManager();
	StatisticsManager statisticsManager(m_database);
	m_handlerFactory = new RequestHandlerFactory(m_database, loginManager, roomManager, statisticsManager);
	try {
		(*m_database).open();
	}
	catch (...) {
		std::cout << "Data base failed to open..." << std::endl;
		exit(0);
	}
}

Server::~Server()
{
	(*m_database).close();
	delete m_database;
}

void Server::run()
{
	m_communicator.startHandleRequests(*m_database);
}

