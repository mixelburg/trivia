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
class Communicator
{
public:
	/*
	cTor to init the socket and the fields
	input + output: none
	*/
	Communicator();

	//dTor
	~Communicator();

	/*
	Function starts handle requests recived from clients
	input + output: none
	*/
	void startHandleRequests();

private:
	/*
	Function binds the socket and listening for requests
	input + output: none
	*/
	void bindAndListen();
	/*
	Function ment to handle a client 
	input + output: none
	*/
	void handleNewClient();
	
	//server socket
	SOCKET m_serverSocket;

	//map to the state of each client
	std::map<SOCKET, IRequestHandler*> m_clients;

	//a factory to hanble the requests of the client
	//RequestHandlerFactory& m_handlerFactory;
};

