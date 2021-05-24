#include "RequestHandlerFactory.h"

LoginRequestHandler RequestHandlerFactory::createLoginRequestHandler(LoginManager& loginManager, RequestHandlerFactory& handlerFactory)
{
    return LoginRequestHandler(loginManager, handlerFactory);
}

MenuRequestHandler RequestHandlerFactory::createMenuRequestHandler(LoggedUser& user, RoomManager& roomManager, StatisticsManager& statisticsManager, RequestHandlerFactory& handlerFactory)
{
    return MenuRequestHandler(user, roomManager, statisticsManager, handlerFactory);
}
