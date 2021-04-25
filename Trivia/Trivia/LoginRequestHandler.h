#pragma once
#include "IRequestHandler.h"

class LoginRequestHandler : public IRequestHandler
{
public:
	LoginRequestHandler() = default;
	virtual ~LoginRequestHandler() override = default;
	/*
	Function checks if the request got from the client is valid and relevant
	input: struct with the client' request
	output: boolean answer if the request is relevant
	*/
	virtual bool isRequestRelevant(const RequestInfo& reqInfo) override;
	/*
	Function handles with the client request
	input: struct with the client' request
	output: struct contains the handle of the request 
	*/
	virtual RequestResult handleRequest(const RequestInfo& reqInfo) override;
};

