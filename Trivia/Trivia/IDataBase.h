#pragma once

class IDataBase {
public:
	virtual ~IDataBase() = default;

	virtual bool open() = 0;
	virtual void close() = 0;
	virtual auto isUser(const std::string& uname) const -> bool = 0;
	virtual auto checkPassword(const std::string& uname, const std::string& pswd) const -> bool = 0;
	virtual auto addUser(const std::string& uname, const std::string& pswd, const std::string& email) const -> void = 0;
};
