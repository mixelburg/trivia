#pragma once

#include <ctime>
#include <vector>
#include <string>

class IRequestHandler;

struct IRequest {
	
};

struct RequestInfo: IRequest {
	unsigned char id;
	time_t receivalTime;
	std::vector<unsigned char> buffer;
};

struct RequestResult: public IRequest {
	std::vector<unsigned char> response;
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

