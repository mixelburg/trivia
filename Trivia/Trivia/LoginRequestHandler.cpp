#include "LoginRequestHandler.h"
#include "Codes.h"
#include "JsonRequestPacketDeserializer.h"

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

RequestResult LoginRequestHandler::login(const RequestInfo& reqInfo)
{
    RequestResult reqResult;
    LoginRequest clientLoginRequest = JsonRequestPacketDeserializer::deserializeLoginRequest(reqInfo.buffer);
    try {
        if (m_loginManager.login(clientLoginRequest.username, clientLoginRequest.password)) {

        }
        else {

        }
    }
    catch(...){
        reqResult.newHandler = nullptr;
    }
    return reqResult;
}
