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
    root = "message:" + errResponse.message;
    auto jsonData = root.asString();
    
    //insert the data' size + the data
    std::string dataSize = Helper::getPaddedNumber(jsonData.length(), LEN_SIZE);
    for (const auto ch : dataSize + jsonData) {
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
    root = "status:" + std::to_string(statusResponse.status);
    auto jsonData = root.asString();

    //insert the data' size + the data
    std::string dataSize = Helper::getPaddedNumber(jsonData.length(), LEN_SIZE);
    for (const auto ch : dataSize + jsonData) {
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

    //get the names of the rooms from the rooms vector
    std::string roomsNames;
    for (const auto room : roomsResponse.rooms) {
        roomsNames += room.name + ", ";
    }
    roomsNames = roomsNames.substr(0, roomsNames.size() - CHARS_TO_REMOVE);
    //create the json object
    Json::Value root;
    root = "status:" + std::to_string(roomsResponse.status) + ",rooms:" + roomsNames;
    auto jsonData = root.asString();

    //insert the data' size + the data
    std::string dataSize = Helper::getPaddedNumber(jsonData.length(), LEN_SIZE);
    for (const auto ch : dataSize + jsonData) {
        buffer.push_back(ch);
    }

    //returning the complete message
    return buffer;
}
