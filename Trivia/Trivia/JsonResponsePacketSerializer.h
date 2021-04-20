#pragma once

#include <string>
#include <vector>

struct IStatusResponse {
public:
	unsigned int status;
};

struct LoginResponse : public IStatusResponse {
};

struct SignupResponse : public IStatusResponse {
};

struct ErrorResponse {
	std::string message;
};

class JsonResponsePacketSerializer
{
public:
	/*
	Function serialize the error response to buffer
	input: struct of the error response
	output: buffer with the error response
	*/
	static std::vector<unsigned char> serializeResponse(const ErrorResponse& errResponse);
	/*
	Function serialize the login response to buffer
	input: strcut of the login response
	output: buffer with the login response
	*/
	static std::vector<unsigned char> serializeResponse(const IStatusResponse& codeResponse);
	

};

