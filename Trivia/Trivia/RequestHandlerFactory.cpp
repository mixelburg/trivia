#include "RequestHandlerFactory.h"

LoginRequestHandler RequestHandlerFactory::createLoginRequestHandler(LoginManager& loginManager, RequestHandlerFactory& handlerFactory)
{
    return LoginRequestHandler(loginManager, handlerFactory);
}

MenuRequestHandler RequestHandlerFactory::createMenuRequestHandler()
{
    return MenuRequestHandler();
}
