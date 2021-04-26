#pragma once
#include "IRequestHandler.h"

class MenuRequestHandler : public IRequestHandler
{
	/*
	Function creates a MenuRequstHandler object
	input: none
	output: none
	*/
	MenuRequestHandler() = default;
	/*
	Function distructs a MenuRequestHandler object
	input: none
	output: none
	*/
	virtual ~MenuRequestHandler() override = default;
	/*
	Function checks if the request got from the client is valid and relevant
	input: struct with the client' request
	output: boolean answer if the request is relevant
	*/
	virtual bool isRequestRelevant(const RequestInfo& reqInfo) override;
	/*
	Function handles with the client request
	input: struct with the client' request
	output: struct contains the handle of the request
	*/
	virtual RequestResult handleRequest(const RequestInfo& reqInfo) override;

private:
	//fields
	//LoggedUser m_user;
	//RoomManager& m_roomManager;
	//StatisticsManager& m_statisticsManager;
	//RequestHandlerFactory& m_handlerFactory;

	//methods
	RequestResult signout(const RequestInfo& reqInfo);
	RequestResult getRooms(const RequestInfo& reqInfo);
	RequestResult getPlayersInRoom(const RequestInfo& reqInfo);
	RequestResult getPersonalStats(const RequestInfo& reqInfo);
	RequestResult getHighScore(const RequestInfo& reqInfo);
	RequestResult joinRoom(const RequestInfo& reqInfo);
	RequestResult createRoom(const RequestInfo& reqInfo);


};

