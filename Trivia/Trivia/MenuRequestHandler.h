#pragma once
#include "IRequestHandler.h"
#include "LoggedUser.h"
#include "RoomManager.h"
#include "StatisticsManager.h"
#include "RequestHandlerFactory.h"

class RequestHandlerFactory;

class MenuRequestHandler : public IRequestHandler
{
public:
	/*
	Function creates a MenuRequstHandler object
	input: none
	output: none
	*/
	MenuRequestHandler(const LoggedUser& user, RoomManager& roomManager, StatisticsManager& statisticsManager,
	                   RequestHandlerFactory& handlerFactory, LoginManager& loginManager);
	/*
	Function distructs a MenuRequestHandler object
	input: none
	output: none
	*/
	~MenuRequestHandler() override = default;
	/*
	Function checks if the request got from the client is valid and relevant
	input: struct with the client' request
	output: boolean answer if the request is relevant
	*/
	const bool isRequestRelevant(const RequestInfo& reqInfo) override;
	/*
	Function handles with the client request
	input: struct with the client' request
	output: struct contains the handle of the request
	*/
	RequestResult handleRequest(const RequestInfo& reqInfo) override;

private:
	//fields
	LoggedUser m_user;
	RoomManager& m_roomManager;
	StatisticsManager& m_statisticsManager;
	RequestHandlerFactory& m_handlerFactory;
	LoginManager& m_loginManager;

	//methods
	RequestResult getRooms(const RequestInfo& reqInfo);
	RequestResult getPlayersInRoom(const RequestInfo& reqInfo);
	RequestResult getPersonalStats(const RequestInfo& reqInfo);
	RequestResult getHighScore(const RequestInfo& reqInfo);
	RequestResult joinRoom(const RequestInfo& reqInfo);
	RequestResult createRoom(const RequestInfo& reqInfo);
	RequestResult logout();
};
