#pragma once

#include <string>
#include <vector>
#include "Codes.h"

struct IStatusResponse {
public:
	IStatusResponse(unsigned int status, unsigned char code):code(code), status(status) {}
	unsigned int status;
	unsigned char code;
};

struct LoginResponse : public IStatusResponse {
	LoginResponse(unsigned int status) : IStatusResponse(status, LOGIN_CODE) {}
};

struct SignupResponse : public IStatusResponse {
	SignupResponse(unsigned int status) : IStatusResponse(status, SIGNUP_CODE) {}
};

struct ErrorResponse {
	ErrorResponse(std::string message) : message(message) {}
	std::string message;
};

// strcuts for version 2 
struct LogoutResponse : public IStatusResponse {
	LogoutResponse(unsigned int status) : IStatusResponse(status, LOGOUT_CODE) {}
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

