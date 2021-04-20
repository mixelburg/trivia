#pragma warning(disable : 4996)
#include "JsonResponsePacketSerializer.h"
#include "json.h"
#include <iostream>
std::vector<unsigned char> JsonResponsePacketSerializer::serializeResponse(const ErrorResponse& errResponse)
{
    std::vector<unsigned char> buffer;
    Json::Value root;
    root = "message:" + errResponse.message;
    const auto jsonData = root.asString();
    for (const auto ch : jsonData) {
        buffer.push_back(ch);
    }
    return buffer;
}

std::vector<unsigned char> JsonResponsePacketSerializer::serializeResponse(const LoginResponse& loginResponse)
{
    std::vector<unsigned char> buffer;
    Json::Value root;
    root = "message:" + std::to_string(loginResponse.status);
    const auto jsonData = root.asString();
    for (const auto ch : jsonData) {
        buffer.push_back(ch);
    }
    return buffer;
}
