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
