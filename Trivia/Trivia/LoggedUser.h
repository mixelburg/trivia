#pragma once
#include <string>

class LoggedUser
{
public:
	LoggedUser(std::string uname);
	~LoggedUser() = default;

	const std::string getUsername() const;
	
private:
	std::string _uname;
};
