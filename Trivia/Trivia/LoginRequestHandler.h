#pragma once
#include "IRequestHandler.h"

class LoginRequestHandler : public IRequestHandler
{
public:
	/*
	Function creats a LoginRequestHandler object
	input: none
	output: none
	*/
	LoginRequestHandler() = default;
	/*
	Function distructs a LoginRequestHandle object
	input: none
	output: none
	*/
	virtual ~LoginRequestHandler() override = default;
	/*
	Function checks if the request got from the client is valid and relevant
	input: struct with the client' request
	output: boolean answer if the request is relevant
	*/
	const virtual bool isRequestRelevant(const RequestInfo& reqInfo) override;
	/*
	Function handles with the client request
	input: struct with the client' request
	output: struct contains the handle of the request 
	*/
	virtual RequestResult handleRequest(const RequestInfo& reqInfo) override;

private:
	//LoginManager& m_loginManager;
	//RequestHandlerFactory& m_handlerFactory;

	/*
	Function performs a login
	input: struct with the login information
	output: struct with the result of the login
	*/
	RequestResult login(const RequestInfo& reqInfo);
	/*
	Function performs a signup
	input: struct with the signup information
	output: struct with the result of the signup
	*/
	RequestResult signup(const RequestInfo& reqInfo);
};

