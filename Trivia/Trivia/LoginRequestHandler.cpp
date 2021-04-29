#include "LoginRequestHandler.h"
#include "Codes.h"
#include "JsonRequestPacketDeserializer.h"

LoginRequestHandler::LoginRequestHandler(LoginManager& loginManager, RequestHandlerFactory& handlerFactory):
    m_loginManager(loginManager), m_handlerFactory(handlerFactory)
{
}

bool LoginRequestHandler::isRequestRelevant(const RequestInfo& reqInfo)
{
    return reqInfo.id == LOGIN_CODE || reqInfo.id == SIGNUP_CODE ? true : false;
}

RequestResult LoginRequestHandler::handleRequest(const RequestInfo& reqInfo)
{
    RequestResult reqResult;
    if (reqInfo.id == LOGIN_CODE) {
        reqResult = login(reqInfo);
    }
    /*
    else {
        reqResult = signup(reqInfo);
    }
    */
    return reqResult;
}

RequestResult LoginRequestHandler::login(const RequestInfo& reqInfo)
{
    RequestResult reqResult;
    LoginRequest clientLoginRequest = JsonRequestPacketDeserializer::deserializeLoginRequest(reqInfo.buffer);
    try {
        if (m_loginManager.login(clientLoginRequest.username, clientLoginRequest.password)) {
            *reqResult.newHandler = m_handlerFactory.createMenuRequestHandler();
            for (const auto ch : "Login approved") {
                reqResult.response.push_back(ch);
            }
        }
        else {
            reqResult.newHandler = this;
            for (const auto ch : "Login denied") {
                reqResult.response.push_back(ch);
            }
        }
    }
    catch(...){
        reqResult.newHandler = nullptr;
    }
    return reqResult;
}
