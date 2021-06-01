#include "RequestHandlerFactory.h"

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

RequestHandlerFactory::~RequestHandlerFactory()
{
    delete m_loginManagerPtr;
    delete m_statisticsManagerPtr;
    delete m_roomManagerPtr;
}
