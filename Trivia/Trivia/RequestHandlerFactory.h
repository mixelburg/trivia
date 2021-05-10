#pragma once
#include "LoginRequestHandler.h"
#include "MenuRequestHandler.h"
#include "IDataBase.h"

class LoginRequestHandler;

class RequestHandlerFactory
{
public:
	/*
	Function creats a RequestHandlerFactory object
	input + output: none
	*/
	RequestHandlerFactory() = default;
	/*
	Function distructs a RequestHandlerFactory object
	input + output: none
	*/
	~RequestHandlerFactory() = default;
	/*
	Function creates a login request handler 
	input: pointer to the data base class
	output: the handler that has been created
	*/
	LoginRequestHandler createLoginRequestHandler(LoginManager& loginManager, RequestHandlerFactory& handlerFactory);
	/*
	Function returns the login manager
	input: none
	output: the login manager
	*/
	//LoginManager& getLoginManager();
	/*
	Function creates a menu request handler
	input: none
	output: the handler that has been created
	*/
	MenuRequestHandler createMenuRequestHandler();
	/*
	Function returns the statistics manager
	input: none
	output: the statistics manager
	*/
	//StatisticsManager& getStatisticsManager();
	/*
	Function returns the room manager
	input: none
	output: the room manager
	*/
	//RoomManager& getRoomManager();
	/*
	Function creates a room admin request handler
	input: none
	output: the handler that has been created
	*/
	//RoomAdminRequestHandler createRoomAdminRequestHandler();
	/*
	Function creats a room member request handler
	input: none
	output: the handler that has been created
	*/
	//RoomMemnerRequestHandler createRoomMemberRequestHandler();
	/*
	Function creats a game request handler
	input: none
	output: the handler that has been created
	*/
	//GameRequestHandler createGameRequestHandler();
	/*
	Function returns the game manager
	input: none
	output: the game manager
	*/
	//GameManager& getGameManager();
private:
	//IDatabase* m_database;
	//LoginManager m_loginManager;
	//RoomManager m_roomManager;
	//StatisticsManager m_statisticsManager;
	//GameManager m_gameManager;
};

