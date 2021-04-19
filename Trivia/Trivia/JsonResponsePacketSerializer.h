#pragma once

#include "json/json.h"

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
	static std::vector<unsigned char> serializeResponse(LoginResponse);
	/*
	Function serialize the signup response to buffer
	input: struct of the signup response
	output: buffer with the signup response
	*/
	static std::vector<unsigned char> serializeResponse(SignupResponse);

};

