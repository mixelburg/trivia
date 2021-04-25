#include "JsonRequestPacketDeserializer.h"
#include "json.h"
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

	bool parsingSuccessful = reader->parse(
		jsonStr.c_str(),
		jsonStr.c_str() + jsonStr.size(),
		&json,
		&errors
	);
	delete reader;

	loginReq.username = json.get("name", NULL).asString();
	loginReq.password = json.get("password", NULL).asString();

	return loginReq;
}
