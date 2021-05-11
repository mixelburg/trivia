#include "RequestHandlerFactory.h"

LoginRequestHandler RequestHandlerFactory::createLoginRequestHandler()
{
    return LoginRequestHandler();
}

MenuRequestHandler RequestHandlerFactory::createMenuRequestHandler(LoggedUser& user, RoomManager& roomManager, StatisticsManager& statisticsManager, RequestHandlerFactory& handlerFactory)
{
    return MenuRequestHandler(user, roomManager, statisticsManager, handlerFactory);
}
