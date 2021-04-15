#include "LoginRequestHandler.h"

bool LoginRequestHandler::isRequestRelevant(const RequestInfo& reqInfo)
{
    return false;
}

RequestResult LoginRequestHandler::handleRequest(const RequestInfo& reqInfo)
{
    return RequestResult();
}
