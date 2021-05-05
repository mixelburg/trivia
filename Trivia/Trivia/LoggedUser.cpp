#include "LoggedUser.h"

#include <utility>

LoggedUser::LoggedUser(std::string uname, std::string pswd) : _uname(std::move(uname)), _pswd(std::move(pswd))
{
}

bool LoggedUser::operator==(const LoggedUser& other)
{
	return this->_uname == other._uname;
}
