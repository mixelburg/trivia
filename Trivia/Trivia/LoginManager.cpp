#include "LoginManager.h"


LoginManager::LoginManager(IDataBase* db) : _db(db)
{
}

auto LoginManager::login(const std::string& uname, const std::string& pswd) -> bool
{
	if (_db->checkPassword(uname, pswd))
	{
		_users.emplace_back(LoggedUser(uname, pswd));
		return true;
	}
	return false;
}

auto LoginManager::signup(const std::string& uname, const std::string& pswd, const std::string& email) -> bool
{
	if (!_db->isUser(uname))
	{
		_db->addUser(uname, pswd, email);
		return login(uname, pswd);
	}
	return false;
}

const LoggedUser& LoginManager::getUserByName(const std::string& uname) const
{
	for (const LoggedUser& user : _users) {
		if (uname == user.getUname()) {
			return user;
		}
	}

	//Just for the compailer :)
	LoggedUser invalidUser("", "");
	return invalidUser;
}

