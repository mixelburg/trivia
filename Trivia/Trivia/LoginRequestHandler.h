#pragma once
#include "IRequestHandler.h"

class LoginRequestHandler : public IRequestHandler
{
public:
	LoginRequestHandler() = default;
	~LoginRequestHandler() = default;
	virtual bool isRequestRelevant(const RequestInfo& reqInfo) override;
	virtual RequestResult handleRequest(const RequestInfo& reqInfo) override;
};

