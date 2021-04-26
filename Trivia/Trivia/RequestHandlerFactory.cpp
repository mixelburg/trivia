#include "RequestHandlerFactory.h"

LoginRequestHandler RequestHandlerFactory::createLoginRequestHandler()
{
    return LoginRequestHandler();
}

MenuRequestHandler RequestHandlerFactory::createMenuRequestHandler()
{
    return MenuRequestHandler();
}
