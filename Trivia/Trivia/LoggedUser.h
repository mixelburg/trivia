#pragma once
#include <string>

class LoggedUser
{
public:
	LoggedUser(std::string uname, std::string pswd);
	~LoggedUser() = default;

	bool operator==(const LoggedUser& other);
	
private:
	std::string _uname;
	std::string _pswd;
};
