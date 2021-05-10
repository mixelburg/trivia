#include "MenuRequestHandler.h"
#include "Codes.h"
#include "JsonResponsePacketSerializer.h"
#include "LoginRequestHandler.h"

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

	res.newHandler = new LoginRequestHandler();
	
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

	
	const GetPlayersInRoomResponse rr(m_roomManager.getRoomState());

	res.response = JsonResponsePacketSerializer::serializeResponse(rr);
	
	return res;
}
