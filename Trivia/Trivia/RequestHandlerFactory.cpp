#include "RequestHandlerFactory.h"

LoginRequestHandler createLoginRequestHandler(IDataBase* dataBaseClass)
{
    LoginManager loginManagerObject(dataBaseClass);
    return LoginRequestHandler(loginManagerObject);
}

MenuRequestHandler RequestHandlerFactory::createMenuRequestHandler()
{
    return MenuRequestHandler();
}
