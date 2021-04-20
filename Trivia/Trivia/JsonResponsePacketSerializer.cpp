#pragma warning(disable : 4996)
#include "JsonResponsePacketSerializer.h"
#include "json/json.h"
#include "json/assertions.h"
#include <iostream>
std::vector<unsigned char> JsonResponsePacketSerializer::serializeResponse(const ErrorResponse& errResponse)
{
    std::vector<unsigned char> buffer;
    Json::Value root;
    return buffer;
}

std::vector<unsigned char> JsonResponsePacketSerializer::serializeResponse(const LoginResponse& loginResponse)
{
    std::vector<unsigned char> buffer;
    //std::string dataInJson = "{\"message\": \"" + std::to_string(loginResponse.status) + "\"}"; // {"status": "1"}
    //for (const auto ch : dataInJson) {
    //    buffer.push_back(ch);
    //}
    return buffer;
}
