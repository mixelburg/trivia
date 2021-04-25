#pragma once

#include "SqliteDataBase.h"

#include <iostream>


auto SqliteDataBase::open() -> bool
{
	const auto res = sqlite3_open(_dbFilename.c_str(), &_db);
	if (res == SQLITE_OK)
	{
		std::cout << "[+] Database opened successfully" << std::endl;
	}
	return res == SQLITE_OK;
}

void SqliteDataBase::close()
{
	sqlite3_close(_db);
	_db = nullptr;
}
