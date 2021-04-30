#pragma once
#include <vector>

#include "LoggedUser.h"
#include "SqliteDataBase.h"

class LoginManager
{
public:
	auto login(const std::string& uname, const std::string& pswd) -> bool;
	auto signup(const std::string& uname, const std::string& pswd, const std::string& email) -> bool;
private:
	std::vector<LoggedUser> _users;
	SqliteDataBase _db;
};
