#pragma once

#include <ctime>
#include <vector>
#include <cstddef>
#include <string>

class IRequestHandler;

struct IRequest {
	
};

struct RequestInfo: public IRequest {
	int id;
	time_t receivalTime;
	std::vector<int> buffer;
};

struct RequestResult: public IRequest {
	std::string response;
	IRequestHandler* newHandler;
};

class IRequestHandler
{
public:
	IRequestHandler() = default;
	virtual ~IRequestHandler() = default;
	virtual bool isRequestRelevant(const RequestInfo& reqInfo) = 0;
	virtual RequestResult handleRequest(const RequestInfo& reqInfo) = 0;
};

