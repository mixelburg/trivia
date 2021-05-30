#include "JsonRequestPacketDeserializer.h"
#include <iostream>

LoginRequest JsonRequestPacketDeserializer::deserializeLoginRequest(const std::vector<unsigned char>& buffer)
{
	LoginRequest loginReq;

	const Json::Value json = parseToJson(buffer);

	loginReq.username = json.get("username", NULL).asString();
	loginReq.password = json.get("password", NULL).asString();

	return loginReq;
}

SignupRequest JsonRequestPacketDeserializer::deserializeSignupRequest(const std::vector<unsigned char>& buffer)
{
	SignupRequest signupReq;

	const Json::Value json = parseToJson(buffer);

	signupReq.username = json.get("username", NULL).asString();
	signupReq.password = json.get("password", NULL).asString();
	signupReq.email = json.get("mail", NULL).asString();

	return signupReq;
}

GetPlayersInRoomRequest JsonRequestPacketDeserializer::deserializeGetPlayersRequest(const std::vector<unsigned char>& buffer)
{
	GetPlayersInRoomRequest getPlayersReq;

	const Json::Value json = parseToJson(buffer);

	getPlayersReq.roomId = json.get("roomId", NULL).asInt();

	return getPlayersReq;
}

JoinRoomRequest JsonRequestPacketDeserializer::deserializeJoinRoomRequest(const std::vector<unsigned char>& buffer)
{
	JoinRoomRequest joinRoomReq;

	const Json::Value json = parseToJson(buffer);

	joinRoomReq.roomId = json.get("roomId", NULL).asInt();

	return joinRoomReq;

}

CreateRoomRequest JsonRequestPacketDeserializer::deserializeCreateRoomRequest(const std::vector<unsigned char>& buffer)
{
	CreateRoomRequest createRoomReq;

	const Json::Value json = parseToJson(buffer);

	createRoomReq.roomName = json.get("name", NULL).asString();
	createRoomReq.maxUsers = json.get("maxUsers", NULL).asInt();
	createRoomReq.questionCount = json.get("questionCount", NULL).asInt();
	createRoomReq.answerTimeout = json.get("answerTimeout", NULL).asInt();

	return createRoomReq;
}

const Json::Value JsonRequestPacketDeserializer::parseToJson(const std::vector<unsigned char>& buffer)
{

	//insreting the buffer into a string
	std::string jsonStr;
	for (const auto ch : buffer) {
		jsonStr += ch;
	}

	//creating json objects to parse the data
	Json::CharReaderBuilder builder;
	Json::CharReader* reader = builder.newCharReader();

	//creating json object to hold the data
	Json::Value json;
	std::string errors;

	//parsing the std::string to a json object
	if (!reader->parse(jsonStr.c_str(), jsonStr.c_str() + jsonStr.size(), &json, &errors)) {
		delete reader;
		throw std::exception("Failed to deserialize");
	}
	delete reader;
	return json;
}
