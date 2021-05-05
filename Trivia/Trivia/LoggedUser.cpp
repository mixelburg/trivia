#include "LoggedUser.h"

#include <utility>

LoggedUser::LoggedUser(std::string uname) : _uname(std::move(uname))
{
}

const std::string LoggedUser::getUsername() const
{
    return _uname;
}
