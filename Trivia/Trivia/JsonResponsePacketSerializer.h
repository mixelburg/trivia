#pragma once

#include <string>
#include <vector>

struct LoginResponse {
	unsigned int status;
};

struct SignupResponse {
	unsigned int status;
};

struct ErrorResponse {
	std::string message;
};

class JsonResponsePacketSerializer
{
	static std::vector<unsigned char> serializeResponse(ErrorResponse);
	static std::vector<unsigned char> serializeResponse(LoginResponse);
	static std::vector<unsigned char> serializeResponse(SignupResponse);

};

