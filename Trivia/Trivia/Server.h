#pragma once

#include <WinSock2.h>
#include <Windows.h>
#include <vector>
#include <queue>
#include <condition_variable>
#include <mutex>
#include <thread>
#include "Helper.h"
#include <fstream>
#include <algorithm>

class Server
{
public:
	Server();
	~Server();
	/*
	Function listening with the listen port of the server for clients
	input: none
	output: none
	*/
	void run();

private:

	void accept();
	void handleClient(SOCKET clientSocket);
	SOCKET m_serverSocket;
	/*
	IDatabase& m_database;
	Communicator m_communicator;
	RequestHandlerFactory m_handlerFactory;
	*/
};
