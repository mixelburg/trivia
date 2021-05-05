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
#include <map>
#include "IRequestHandler.h"
#include "LoginRequestHandler.h"
#include "Communicator.h"
#include "SqliteDataBase.h"

class Server
{
public:
	Server();
	~Server() = default;
	/*
	Function inits the server' commponents
	input: none
	output: none
	*/
	void run();

private:
	SqliteDataBase m_database;
	Communicator m_communicator;
	RequestHandlerFactory m_handlerFactory;
};
