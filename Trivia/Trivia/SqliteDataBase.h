#pragma once
#include <string>
#include "sqlite3.h"
#include "IDataBase.h"

class SqliteDataBase : IDataBase {
public:
	virtual ~SqliteDataBase() = default;

	auto isUser(std::string uname) const -> bool;
	auto checkPassword(std::string uname, std::string pswd) -> bool;
	auto addUser(std::string uname, std::string pswd, std::string email) -> void;

	auto open() -> bool override;
	void close() override;
private:
	sqlite3* _db;
	std::string _dbFilename = "db.sqlite";
};
