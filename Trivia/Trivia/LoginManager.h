#pragma once
#include <vector>

#include "LoggedUser.h"
#include "SqliteDataBase.h"

class LoginManager
{
public:
	LoginManager(IDataBase* db);

	bool login(const std::string& uname, const std::string& pswd);
	bool signup(const std::string& uname, const std::string& pswd, const std::string& email);
	const LoggedUser& getUserByName(const std::string& uname) const;


private:
	std::vector<LoggedUser> _users;
	IDataBase* _db;
};
