#pragma once
#include <vector>

#include "LoggedUser.h"
#include "SqliteDataBase.h"

class LoginManager
{
public:
	LoginManager(IDataBase* db);

	/**
	 * @brief adds user to the vector of connected users if password is correct
	 * fails if user is already connected or if password is incorrect
	 * @param uname name of user to add
	 * @param pswd password of user to add
	 * @return (true/false) success or fail
	*/
	bool login(const std::string& uname, const std::string& pswd);

	/**
	 * @brief add new user to the database and then to the list of connected users
	 * fails if user is already in the database 
	 * @param uname name of user to add
	 * @param pswd password of user to add
	 * @param email - email of user to add
	 * @return (true/false) success or fail
	*/
	bool signup(const std::string& uname, const std::string& pswd, const std::string& email);

	/**
	 * @brief returns object (LoggedUser) from list of connected users by username
	 * @param uname name of user to search for
	 * @return reference to an object (LoggedUser)
	*/
	const LoggedUser& getUserByName(const std::string& uname) const;


private:
	std::vector<LoggedUser> _users;
	IDataBase* _db;
};
