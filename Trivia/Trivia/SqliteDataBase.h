#pragma once
#include <string>
#include "sqlite3.h"
#include "IDataBase.h"

class SqliteDataBase : IDataBase {
public:
	virtual ~SqliteDataBase() = default;

	auto open() -> bool override;
	void close() override;
private:
	sqlite3* _db;
	std::string _dbFilename = "db.sqlite";
};
