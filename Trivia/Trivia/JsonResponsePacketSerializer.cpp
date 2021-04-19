#include "JsonResponsePacketSerializer.h"

std::vector<unsigned char> JsonResponsePacketSerializer::serializeResponse(const ErrorResponse& errResponse)
{
    std::vector<unsigned char> buffer;
    for (const auto ch : errResponse.message) {
        buffer.push_back(ch);
    }
    return buffer;
}
