#include "RequestHandlerFactory.h"

#define LOGIN "login"
#define MENU "menu"


RequestHandlerFactory::RequestHandlerFactory(IDataBase* database, LoginManager* loginManager, RoomManager* roomManager, StatisticsManager* statisticsManager) : m_database(database), m_loginManagerPtr(loginManager), m_roomManagerPtr(roomManager), m_statisticsManagerPtr(statisticsManager)
{
}

LoginRequestHandler* RequestHandlerFactory::createLoginRequestHandler(LoginManager& loginManager, RequestHandlerFactory& handlerFactory)
{
    return new LoginRequestHandler(loginManager, handlerFactory);
}

LoginManager& RequestHandlerFactory::getLoginManager()
{
    return *m_loginManagerPtr;
}

MenuRequestHandler* RequestHandlerFactory::createMenuRequestHandler(const LoggedUser& user, RoomManager& roomManager, StatisticsManager& statisticsManager, RequestHandlerFactory& handlerFactory, LoginManager& loginManager)
{
    return new MenuRequestHandler(user, roomManager, statisticsManager, handlerFactory, loginManager);
}

StatisticsManager& RequestHandlerFactory::getStatisticsManager()
{
    return *m_statisticsManagerPtr;
}

RoomManager& RequestHandlerFactory::getRoomManager()
{
    return *m_roomManagerPtr;
}

void RequestHandlerFactory::updateHandlers(RequestResult& reqRes, const std::string& newHandlerName, LoggedUser* userPtr)
{
    IRequestHandler* temp = nullptr;
    temp = reqRes.newHandler;
    if (newHandlerName == LOGIN) {
        reqRes.newHandler = createLoginRequestHandler(*m_loginManagerPtr, *this);
    }
    else if (newHandlerName == MENU) {
        reqRes.newHandler = createMenuRequestHandler(*userPtr, *m_roomManagerPtr, *m_statisticsManagerPtr, *this, *m_loginManagerPtr);
    }
    delete temp;
}

RequestHandlerFactory::~RequestHandlerFactory()
{
    delete m_loginManagerPtr;
    delete m_statisticsManagerPtr;
    delete m_roomManagerPtr;
}
