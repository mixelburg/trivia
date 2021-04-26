#include "LoginRequestHandler.h"
#include "Codes.h"

LoginRequestHandler::LoginRequestHandler(LoginManager& m) : m_loginManager(m)
{
}

bool LoginRequestHandler::isRequestRelevant(const RequestInfo& reqInfo)
{
    return reqInfo.id == LOGIN_CODE || reqInfo.id == SIGNUP_CODE ? true : false;
}

RequestResult LoginRequestHandler::handleRequest(const RequestInfo& reqInfo)
{
    RequestResult reqResult;
    /*if (reqInfo.id == LOGIN_CODE) {
        reqResult = login(reqInfo);
    }
    else {
        reqResult = signup(reqInfo);
    }*/
    return reqResult;
}
