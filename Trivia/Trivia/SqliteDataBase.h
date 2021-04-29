#pragma once
#include <string>
#include "sqlite3.h"
#include "IDataBase.h"

class SqliteDataBase : public IDataBase {
public:
	virtual ~SqliteDataBase() = default;

	auto isUser(const std::string& uname) const -> bool override;
	auto checkPassword(const std::string& uname, const std::string& pswd) const -> bool override;
	auto addUser(const std::string& uname, const std::string& pswd, const std::string& email) const -> void override;

	auto open() -> bool override;
	void close() override;
private:
	sqlite3* _db;
	std::string _dbFilename = "db.sqlite";
};
