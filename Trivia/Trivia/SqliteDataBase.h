#pragma once
#include <string>
#include "sqlite3.h"
#include "IDataBase.h"

class SqliteDataBase : IDataBase {
public:
	virtual ~SqliteDataBase() = default;

	auto isUser(const std::string& uname) const -> bool;
	auto checkPassword(const std::string& uname, const std::string& pswd) const -> bool;
	auto addUser(const std::string& uname, const std::string& pswd, const std::string& email) const -> void;

	auto open() -> bool override;
	void close() override;
private:
	sqlite3* _db;
	std::string _dbFilename = "db.sqlite";
};
