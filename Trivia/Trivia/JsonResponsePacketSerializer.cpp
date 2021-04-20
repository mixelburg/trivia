#pragma warning(disable : 4996)
#include "JsonResponsePacketSerializer.h"
#include "json.h"
#include <iostream>
#include "Helper.h"

#define TO_NUMBER 48
#define LEN_SIZE 4

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

std::vector<unsigned char> JsonResponsePacketSerializer::serializeResponse(const IStatusResponse& statusResponse)
{
    std::vector<unsigned char> buffer;
    
    //insert the message code
    buffer.push_back(statusResponse.code + TO_NUMBER);
    
    //create the json object
    Json::Value root;
    root = "status:" + std::to_string(statusResponse.status);
    auto jsonData = root.asString();

    //insert the data' size
    std::string dataSize = Helper::getPaddedNumber(jsonData.length(), LEN_SIZE);

    for (const auto ch : dataSize + jsonData) {
        buffer.push_back(ch);
    }
    return buffer;
}

