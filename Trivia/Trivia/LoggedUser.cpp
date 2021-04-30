#include "LoggedUser.h"

#include <utility>

LoggedUser::LoggedUser(std::string uname, std::string pswd) : _uname(std::move(uname)), _pswd(std::move(pswd))
{
}
