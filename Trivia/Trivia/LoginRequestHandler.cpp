#include "LoginRequestHandler.h"
#include "Codes.h"
#include "JsonRequestPacketDeserializer.h"
#define SUCCESS 1
#define FAIL 0
LoginRequestHandler::LoginRequestHandler(LoginManager& loginManager, RequestHandlerFactory& handlerFactory):
    m_loginManager(loginManager), m_handlerFactory(handlerFactory)
{
}

const bool LoginRequestHandler::isRequestRelevant(const RequestInfo& reqInfo)
{
    return reqInfo.id == LOGIN_CODE || reqInfo.id == SIGNUP_CODE ? true : false;
}

RequestResult LoginRequestHandler::handleRequest(const RequestInfo& reqInfo)
{
    RequestResult reqResult;
    if (reqInfo.id == LOGIN_CODE) {
        reqResult = login(reqInfo);
    }
    
    else {
        reqResult = signup(reqInfo);
    }
    
    return reqResult;
}

RequestResult LoginRequestHandler::login(const RequestInfo& reqInfo)
{
    RequestResult reqResult;
    LoginRequest clientLoginRequest = JsonRequestPacketDeserializer::deserializeLoginRequest(reqInfo.buffer);
    try {
        if (m_loginManager.login(clientLoginRequest.username, clientLoginRequest.password)) {
            const LoggedUser& currUser = m_loginManager.getUserByName(clientLoginRequest.username);
            *reqResult.newHandler = m_handlerFactory.createMenuRequestHandler(currUser, m_handlerFactory.getRoomManager(), m_handlerFactory.getStatisticsManager(), m_handlerFactory);
            reqResult.response.push_back(SUCCESS);
        }
        else {
            reqResult.newHandler = this;
            reqResult.response.push_back(FAIL);

        }
    }
    catch(...){
        reqResult.newHandler = nullptr;
    }
    return reqResult;
}

RequestResult LoginRequestHandler::signup(const RequestInfo& reqInfo)
{
    RequestResult reqResult;
    SignupRequest clientLoginRequest = JsonRequestPacketDeserializer::deserializeSignupRequest(reqInfo.buffer);
    try {
        if (m_loginManager.signup(clientLoginRequest.username, clientLoginRequest.password, clientLoginRequest.email)) {
            const LoggedUser& newUser = m_loginManager.getUserByName(clientLoginRequest.username);
            *reqResult.newHandler = m_handlerFactory.createMenuRequestHandler(newUser, m_handlerFactory.getRoomManager(), m_handlerFactory.getStatisticsManager(), m_handlerFactory);
            reqResult.response.push_back(SUCCESS);

        }
        else {
            reqResult.newHandler = this;
            reqResult.response.push_back(FAIL);

        }
    }
    catch (...) {
        reqResult.newHandler = nullptr;
    }
    return reqResult;
}
