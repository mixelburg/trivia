#include "MenuRequestHandler.h"
#include "Codes.h"
#include "JsonResponsePacketSerializer.h"
#include "JsonRequestPacketDeserializer.h"
#include "LoginRequestHandler.h"

MenuRequestHandler::MenuRequestHandler(const LoggedUser& user, RoomManager& roomManager,
                                       StatisticsManager& statisticsManager, RequestHandlerFactory& handlerFactory,
                                       LoginManager& loginManager)
	: m_user(user), m_roomManager(roomManager), m_statisticsManager(statisticsManager),
	  m_handlerFactory(handlerFactory), m_loginManager(loginManager)
{
}

const bool MenuRequestHandler::isRequestRelevant(const RequestInfo& reqInfo)
{
	return reqInfo.id == LOGOUT_CODE ||
	       reqInfo.id == GET_ROOMS_CODE ||
	       reqInfo.id == GET_PLAYERS_CODE ||
	       reqInfo.id == GET_HIGH_SCORE_CODE ||
	       reqInfo.id == GET_STATS_CODE ||
	       reqInfo.id == JOIN_ROOM_CODE ||
	       reqInfo.id == CREATE_ROOM_CODE
		       ? true
		       : false;
}

RequestResult MenuRequestHandler::handleRequest(const RequestInfo& reqInfo)
{
	switch (reqInfo.id)
	{
	case GET_ROOMS_CODE:
		return getRooms(reqInfo);
	case GET_PLAYERS_CODE:
		return getPlayersInRoom(reqInfo);
	case GET_STATS_CODE:
		return getPersonalStats(reqInfo);
	case GET_HIGH_SCORE_CODE:
		return getHighScore(reqInfo);
	case JOIN_ROOM_CODE:
		return joinRoom(reqInfo);
	case CREATE_ROOM_CODE:
		return createRoom(reqInfo);
	default:
		return RequestResult();
	}
}

RequestResult MenuRequestHandler::getRooms(const RequestInfo& reqInfo)
{
	RequestResult res;
	res.newHandler = this;

	const GetRoomsResponse rr(1, m_roomManager.getRooms());
	res.response = JsonResponsePacketSerializer::serializeResponse(rr);

	return res;
}

RequestResult MenuRequestHandler::getPlayersInRoom(const RequestInfo& reqInfo)
{
	RequestResult res;
	res.newHandler = this;

	const int id = JsonRequestPacketDeserializer::deserializeGetPlayersRequest(reqInfo.buffer).roomId;
	const GetPlayersInRoomResponse rr(m_roomManager.getAllUsers(id));

	res.response = JsonResponsePacketSerializer::serializeResponse(rr);

	return res;
}

RequestResult MenuRequestHandler::getPersonalStats(const RequestInfo& reqInfo)
{
	RequestResult res;
	res.newHandler = this;

	const GetPersonalStatsResponse rr(1, m_statisticsManager.getUserStatistics(m_user.getUname()));
	res.response = JsonResponsePacketSerializer::serializeResponse(rr);

	return res;
}

RequestResult MenuRequestHandler::getHighScore(const RequestInfo& reqInfo)
{
	RequestResult res;
	res.newHandler = this;

	const GetHighScoreResponse rr(1, m_statisticsManager.getHighScore());
	res.response = JsonResponsePacketSerializer::serializeResponse(rr);

	return res;
}

RequestResult MenuRequestHandler::joinRoom(const RequestInfo& reqInfo)
{
	RequestResult res;
	res.newHandler = this;

	const int id = JsonRequestPacketDeserializer::deserializeJoinRoomRequest(reqInfo.buffer).roomId;
	m_roomManager.addUser(m_user, id);

	const JoinRoomResponse rr(1);
	res.response = JsonResponsePacketSerializer::serializeResponse(rr);

	return res;
}

RequestResult MenuRequestHandler::createRoom(const RequestInfo& reqInfo)
{
	RequestResult res;
	res.newHandler = this;

	const auto data = JsonRequestPacketDeserializer::deserializeCreateRoomRequest(reqInfo.buffer);

	RoomData roomData;
	roomData.isActive = true;
	roomData.maxPlayers = data.maxUsers;
	roomData.name = data.roomName;
	roomData.numOfQuestionsInGame = data.questionCount;
	roomData.timePerQuestion = data.answerTimeout;

	m_roomManager.createRoom(m_user, roomData);
	const CreateRoomResponse rr(1);
	res.response = JsonResponsePacketSerializer::serializeResponse(rr);

	return res;
}
