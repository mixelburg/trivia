#include "LoginRequestHandler.h"
#include "Codes.h"

bool LoginRequestHandler::isRequestRelevant(const RequestInfo& reqInfo)
{
    return reqInfo.id == LOGIN_CODE || reqInfo.id == SIGNUP_CODE ? true : false;
}

RequestResult LoginRequestHandler::handleRequest(const RequestInfo& reqInfo)
{
    RequestResult loginReqRes;
    return loginReqRes;
}
