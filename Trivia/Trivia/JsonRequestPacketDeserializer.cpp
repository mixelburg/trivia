#include "JsonRequestPacketDeserializer.h"
#include "json/json.h"
#include <iostream>

LoginRequest JsonRequestPacketDeserializer::deserializeLoginRequest(const std::vector<unsigned char>& buffer)
{
	LoginRequest loginReq;

	std::string jsonStr;
	for (const auto ch : buffer) {
		jsonStr += ch;
	}
	
	Json::CharReaderBuilder builder;
	Json::CharReader* reader = builder.newCharReader();

	Json::Value json;
	std::string errors;

	if (!reader->parse(jsonStr.c_str(), jsonStr.c_str() + jsonStr.size(), &json, &errors)) {
		delete reader;
		throw std::exception("Failed to deserialize");
	}
	delete reader;

	loginReq.username = json.get("username", NULL).asString();
	loginReq.password = json.get("password", NULL).asString();

	return loginReq;
}

SignupRequest JsonRequestPacketDeserializer::deserializeSignupRequest(const std::vector<unsigned char>& buffer)
{
	SignupRequest signupReq;

	std::string jsonStr;
	for (const auto ch : buffer) {
		jsonStr += ch;
	}

	Json::CharReaderBuilder builder;
	Json::CharReader* reader = builder.newCharReader();

	Json::Value json;
	std::string errors;

	if (!reader->parse(jsonStr.c_str(), jsonStr.c_str() + jsonStr.size(), &json, &errors)) {
		delete reader;
		throw std::exception("Failed to deserialize");
	}
	delete reader;
	
	signupReq.username = json.get("username", NULL).asString();
	signupReq.password = json.get("password", NULL).asString();
	signupReq.email = json.get("mail", NULL).asString();
	
	return signupReq;
}

GetPlayersInRoomRequest JsonRequestPacketDeserializer::deserializeGetPlayersRequest(const std::vector<unsigned char>& buffer)
{
	GetPlayersInRoomRequest getPlayersReq;

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

	getPlayersReq.roomId = json.get("roomId", NULL).asInt();

	return getPlayersReq;
}
