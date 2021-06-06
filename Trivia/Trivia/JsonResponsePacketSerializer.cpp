#pragma warning(disable : 4996)

#include "JsonResponsePacketSerializer.h"
#include "json/json.h"
#include <iostream>
#include "Helper.h"

#define CHARS_TO_REMOVE 2
#define LEN_SIZE 4

std::vector<unsigned char> JsonResponsePacketSerializer::serializeResponse(const ErrorResponse& errResponse)
{
	std::vector<unsigned char> buffer;

	//insert the message code
	buffer.push_back(ERROR_CODE);

	//create the json object
	Json::Value root;

	root["message"] = errResponse.message;
	std::string out = root.toStyledString();

	//insert the data' size + the data
	std::string dataSize = Helper::getPaddedNumber(out.length(), LEN_SIZE);
	for (const auto ch : dataSize + out)
	{
		buffer.push_back(ch);
	}

	//returning the complete message
	return buffer;
}

std::vector<unsigned char> JsonResponsePacketSerializer::serializeResponse(const IStatusResponse& statusResponse)
{
	std::vector<unsigned char> buffer;

	//insert the message code
	buffer.push_back(statusResponse.code);

	//create the json object
	Json::Value root;

	root["status"] = std::to_string(statusResponse.status);
	std::string out = root.toStyledString();

	//insert the data' size + the data
	std::string dataSize = Helper::getPaddedNumber(out.length(), LEN_SIZE);
	for (const auto ch : dataSize + out)
	{
		buffer.push_back(ch);
	}

	//returning the complete message
	return buffer;
}

std::vector<unsigned char> JsonResponsePacketSerializer::serializeResponse(const GetRoomsResponse& roomsResponse)
{
	std::vector<unsigned char> buffer;

	//inserting the message code
	buffer.push_back(roomsResponse.code);

	//get the names of the rooms + their id from the rooms vector
	std::string roomsNames;
	std::string roomsIds;
	for (const auto room : roomsResponse.rooms)
	{
		roomsNames += room.name + ", ";
		roomsIds += std::to_string(room.id) + ", ";
	}
	roomsNames = roomsNames.substr(0, roomsNames.size() - CHARS_TO_REMOVE);
	roomsIds = roomsIds.substr(0, roomsIds.size() - CHARS_TO_REMOVE);

	//create the json object
	Json::Value root;

	root["status"] = std::to_string(roomsResponse.status);
	root["roomsNames"] = roomsNames;
	root["roomsIds"] = roomsIds;
	std::string out = root.toStyledString();

	//insert the data' size + the data
	std::string dataSize = Helper::getPaddedNumber(out.length(), LEN_SIZE);
	for (const auto ch : dataSize + out)
	{
		buffer.push_back(ch);
	}

	//returning the complete message
	return buffer;
}

std::vector<unsigned char> JsonResponsePacketSerializer::serializeResponse(
	const GetPlayersInRoomResponse& playersResponse)
{
	std::vector<unsigned char> buffer;

	//inserting the message code
	buffer.push_back(playersResponse.code);

	//get the names of the rooms from the rooms vector
	std::string playersNames;
	for (const auto player : playersResponse.players)
	{
		playersNames += player + ", ";
	}
	playersNames = playersNames.substr(0, playersNames.size() - CHARS_TO_REMOVE);

	//create the json object
	Json::Value root;
	root["PlayersInRoom"] = playersNames;
	std::string out = root.toStyledString();

	//insert the data' size + the data
	std::string dataSize = Helper::getPaddedNumber(out.length(), LEN_SIZE);
	for (const auto ch : dataSize + out)
	{
		buffer.push_back(ch);
	}

	//returning the complete message
	return buffer;
}

std::vector<unsigned char> JsonResponsePacketSerializer::serializeResponse(
	const GetPersonalStatsResponse& statsResponse)
{
	std::vector<unsigned char> buffer;

	//inserting the message code
	buffer.push_back(statsResponse.code);

	//inserting the stats to a string 
	std::string statsInString;
	for (const auto statistic : statsResponse.statistics)
	{
		statsInString += statistic + ", ";
	}
	statsInString = statsInString.substr(0, statsInString.size() - CHARS_TO_REMOVE);

	//create the json object
	Json::Value root;

	root["UserStatistics"] = statsInString;
	std::string out = root.toStyledString();

	//insert the data' size + the data
	std::string dataSize = Helper::getPaddedNumber(out.length(), LEN_SIZE);
	for (const auto ch : dataSize + out)
	{
		buffer.push_back(ch);
	}

	//returning the complete message
	return buffer;
}

std::vector<unsigned char> JsonResponsePacketSerializer::serializeResponse(
	const GetHighScoreResponse& highScoresResponse)
{
	std::vector<unsigned char> buffer;

	//inserting the message code
	buffer.push_back(highScoresResponse.code);

	//inserting the scores to a string 
	std::string scoreInString;
	for (const auto score : highScoresResponse.highScore)
	{
		scoreInString += score + ", ";
	}
	scoreInString = scoreInString.substr(0, scoreInString.size() - CHARS_TO_REMOVE);

	//create the json object
	Json::Value root;
	root["HighScores"] = scoreInString;
	std::string out = root.toStyledString();

	//insert the data' size + the data
	std::string dataSize = Helper::getPaddedNumber(out.length(), LEN_SIZE);
	for (const auto ch : dataSize + out)
	{
		buffer.push_back(ch);
	}

	//returning the complete message
	return buffer;
}

std::vector<unsigned char> JsonResponsePacketSerializer::serializeResponse(const CreateRoomResponse& createRoomResponse)
{
	std::vector<unsigned char> buffer;

	//inserting the message code
	buffer.push_back(createRoomResponse.code);

	//create the json object
	Json::Value root;

	root["status"] = std::to_string(createRoomResponse.status);
	root["roomId"] = createRoomResponse.roomId;
	std::string out = root.toStyledString();

	//insert the data' size + the data
	std::string dataSize = Helper::getPaddedNumber(out.length(), LEN_SIZE);
	for (const auto ch : dataSize + out)
	{
		buffer.push_back(ch);
	}

	//returning the complete message
	return buffer;
}
