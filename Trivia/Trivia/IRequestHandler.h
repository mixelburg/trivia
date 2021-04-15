#pragma once

#include <ctime>
#include <vector>
#include <cstddef>
#include <string>

class IRequestHandler;

struct RequestInfo {
	int id;
	time_t receivalTime;
	std::vector<int> buffer;
};

struct RequestResult {
	std::string response;
	IRequestHandler* newHandler;
};

class IRequestHandler
{
public:
	virtual bool isRequestRelevant(const RequestInfo& reqInfo) = 0;
	virtual RequestResult handleRequest(const RequestInfo& reqInfo) = 0;
};

