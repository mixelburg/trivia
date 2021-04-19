#include "Communicator.h"
#include <iostream>

#define LISTEN_PORT 5050
#define HELLO_LEN 5

Communicator::Communicator()
{
	//setting the socket to communicate with the clients
	m_serverSocket = socket(AF_INET, SOCK_STREAM, IPPROTO_TCP);

	//throws an error if the socket is invalid
	if (m_serverSocket == INVALID_SOCKET) {
		throw std::exception(__FUNCTION__ " - socket");
	}
}
