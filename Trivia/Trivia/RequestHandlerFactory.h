#pragma once
#include "LoginRequestHandler.h"
#include "MenuRequestHandler.h"
#include "IDataBase.h"
class LoginRequestHandler;
class MenuRequestHandler;

class RequestHandlerFactory
{
public:
	/*
	Function creats a RequestHandlerFactory object
	input + output: none
	*/
	RequestHandlerFactory(IDataBase* database, LoginManager* loginManager, RoomManager* roomManager, StatisticsManager* statisticsManager);
	/*
	Function distructs a RequestHandlerFactory object
	input + output: none
	*/
	~RequestHandlerFactory();
	/*
	Function creates a login request handler 
	input: none
	output: the handler that has been created
	*/
	LoginRequestHandler createLoginRequestHandler(LoginManager& loginManager, RequestHandlerFactory& handlerFactory);
	/*
	Function returns the login manager
	input: none
	output: the login manager
	*/
	LoginManager& getLoginManager();
	/*
	Function creates a menu request handler
	input: none
	output: the handler that has been created
	*/
	MenuRequestHandler createMenuRequestHandler(const LoggedUser& user, RoomManager& roomManager, StatisticsManager& statisticsManager, RequestHandlerFactory& handlerFactory, LoginManager& loginManager);
	/*
	Function returns the statistics manager
	input: none
	output: the statistics manager
	*/
	StatisticsManager& getStatisticsManager();
	/*
	Function returns the room manager
	input: none
	output: the room manager
	*/
	RoomManager& getRoomManager();
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
	IDataBase* m_database;
	LoginManager* m_loginManagerPtr;
	RoomManager* m_roomManagerPtr;
	StatisticsManager* m_statisticsManagerPtr;
	//GameManager m_gameManager;
};

