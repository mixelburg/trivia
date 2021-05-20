#include "MenuRequestHandler.h"
#include "Codes.h"
#include "JsonResponsePacketSerializer.h"
#include "JsonRequestPacketDeserializer.h"
#include "LoginRequestHandler.h"

MenuRequestHandler::MenuRequestHandler(LoggedUser& user, RoomManager& roomManager, StatisticsManager& statisticsManager, RequestHandlerFactory& handlerFactory) : m_user(user), m_roomManager(roomManager), m_statisticsManager(statisticsManager), m_handlerFactory(handlerFactory)
{
}

bool MenuRequestHandler::isRequestRelevant(const RequestInfo& reqInfo)
{
    return false;
}

RequestResult MenuRequestHandler::handleRequest(const RequestInfo& reqInfo)
{
	switch (reqInfo.id)
	{
	case LOGOUT_CODE:
		return signout(reqInfo);
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

RequestResult MenuRequestHandler::signout(const RequestInfo& reqInfo)
{
	RequestResult res;
	LoginRequestHandler h = m_handlerFactory.createLoginRequestHandler();

	res.newHandler = &h;
	
	return res;
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

	// TODO: deal with it
	//const std::string uname = JsonRequestPacketDeserializer::
	//const GetPersonalStatsResponse rr(1, m_statisticsManager.getUserStatistics());
	//res.response = JsonResponsePacketSerializer::serializeResponse(rr);

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

	// TODO: deal with it
	//const int id = JsonRequestPacketDeserializer::deserializeJoinRoomRequest(reqInfo.buffer).roomId;
	//for (const auto& room: m_roomManager.getRooms())
	//{
	//	if (room.id == id)
	//	{
	//		
	//	}
	//}
	//const JoinRoomResponse rr();
	//res.response = JsonResponsePacketSerializer::serializeResponse(rr);

	return res;
}

RequestResult MenuRequestHandler::createRoom(const RequestInfo& reqInfo)
{
	RequestResult res;
	res.newHandler = this;

	const auto data = JsonRequestPacketDeserializer::deserializeCreateRoomRequest(reqInfo.buffer);

	// TODO change room id generation implementation
	RoomData roomData;
	roomData.id = m_roomManager.getRooms().size() + 1;
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
