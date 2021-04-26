#include "LoginManager.h"


auto LoginManager::login(const std::string& uname, const std::string& pswd) -> bool
{
	if(_db.checkPassword(uname, pswd))
	{
		_users.emplace_back(LoggedUser(uname));
		return true;
	}
	return false;
}

auto LoginManager::signup(const std::string& uname, const std::string& pswd, const std::string& email) -> bool
{
	if(!_db.isUser(uname))
	{
		_db.addUser(uname, pswd, email);
		return login(uname, pswd);
	}
	return false;
}

