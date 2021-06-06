#include "LoginManager.h"


LoginManager::LoginManager(IDataBase* db) : _db(db)
{
}

bool LoginManager::login(const std::string& uname, const std::string& pswd)
{
	if (_db->checkPassword(uname, pswd))
	{
		for (const auto& user : _users) {
			if (user.getUname() == uname) {
				return false;
			}
		}
		_users.emplace_back(LoggedUser(uname, pswd));
		return true;
	}
	return false;
}

bool LoginManager::signup(const std::string& uname, const std::string& pswd, const std::string& email)
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
	for (const LoggedUser& user : _users)
	{
		if (uname == user.getUname())
		{
			return user;
		}
	}

	//Just for the compailer :)
	LoggedUser invalidUser("", "");
	return invalidUser;
}

void LoginManager::removeUserByName(const std::string& uname)
{
	const auto it =
		std::find_if(_users.begin(), _users.end(),
			[&uname](const LoggedUser& obj) {return obj.getUname() == uname; });

	if (it != _users.end())
	{
		// found element. it is an iterator to the first matching element.
		// if you really need the index, you can also get it:
		auto index = std::distance(_users.begin(), it);
	}

	_users.erase(it);
}
