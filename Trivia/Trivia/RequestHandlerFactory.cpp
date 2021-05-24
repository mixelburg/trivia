#include "RequestHandlerFactory.h"

RequestHandlerFactory::RequestHandlerFactory(IDataBase* database, LoginManager& loginManager, RoomManager& roomManager, StatisticsManager& statisticsManager) : m_database(database), m_loginManager(loginManager), m_roomManager(roomManager), m_statisticsManager(statisticsManager)
{
}

LoginRequestHandler RequestHandlerFactory::createLoginRequestHandler(LoginManager& loginManager, RequestHandlerFactory& handlerFactory)
{
    return LoginRequestHandler(loginManager, handlerFactory);
}

LoginManager& RequestHandlerFactory::getLoginManager()
{
    return m_loginManager;
}

MenuRequestHandler RequestHandlerFactory::createMenuRequestHandler(const LoggedUser& user, RoomManager& roomManager, StatisticsManager& statisticsManager, RequestHandlerFactory& handlerFactory, LoginManager& loginManager)
{
    return MenuRequestHandler(user, roomManager, statisticsManager, handlerFactory, loginManager);
}

StatisticsManager& RequestHandlerFactory::getStatisticsManager()
{
    return m_statisticsManager;
}

RoomManager& RequestHandlerFactory::getRoomManager()
{
    return m_roomManager;
}
