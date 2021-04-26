#include "MenuRequestHandler.h"

bool MenuRequestHandler::isRequestRelevant(const RequestInfo& reqInfo)
{
    return false;
}

RequestResult MenuRequestHandler::handleRequest(const RequestInfo& reqInfo)
{
    return RequestResult();
}
