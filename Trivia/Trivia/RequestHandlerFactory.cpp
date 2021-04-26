#include "RequestHandlerFactory.h"

LoginRequestHandler RequestHandlerFactory::createLoginRequestHandler()
{
    LoginManager loginManagerObject(nullptr);
    return LoginRequestHandler(loginManagerObject);
}

MenuRequestHandler RequestHandlerFactory::createMenuRequestHandler()
{
    return MenuRequestHandler();
}
