#include "JsonResponsePacketSerializer.h"
#include "json/json.h"

std::vector<unsigned char> JsonResponsePacketSerializer::serializeResponse(const ErrorResponse& errResponse)
{
    std::vector<unsigned char> buffer;
    std::string dataInJson = "{\"message\": \"" + errResponse.message + "\"}"; // {"message": "ERROR"}
    Json::Reader reader;
    Json::Value root;
    if (reader.parse(dataInJson, root, false)) {
        const std::string resultValue = root["result"].asString();
        for (const auto ch : "{ \"message\": \"") {
            buffer.push_back(ch);
        }
        for (const auto ch : resultValue) {
            buffer.push_back(ch);
        }
        for (const auto ch : "\"}") {
            buffer.push_back(ch);
        }
    }
   
    return buffer;
}

std::vector<unsigned char> JsonResponsePacketSerializer::serializeResponse(const LoginResponse& loginResponse)
{
    std::vector<unsigned char> buffer;
    std::string dataInJson = "{\"message\": \"" + std::to_string(loginResponse.status) + "\"}"; // {"status": "1"}
    for (const auto ch : dataInJson) {
        buffer.push_back(ch);
    }
    return buffer;
}
