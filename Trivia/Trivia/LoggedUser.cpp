#include "LoggedUser.h"

#include <utility>

LoggedUser::LoggedUser(std::string uname) : _uname(std::move(uname))
{
}

const std::string LoggedUser::getUsername()
{
    return _uname;
}
