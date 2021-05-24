#pragma once
#include <string>

class LoggedUser
{
public:
	LoggedUser(std::string uname, std::string pswd);
	~LoggedUser() = default;

	//Overloading == operator
	bool operator==(const LoggedUser& other);
	//getter for the username field
	std::string getUname() const;

private:
	std::string _uname;
	std::string _pswd;
};
