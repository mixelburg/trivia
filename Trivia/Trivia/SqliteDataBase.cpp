#pragma once

#include "SqliteDataBase.h"

#include <iostream>


auto SqliteDataBase::isUser(std::string uname) const -> bool
{
	bool flag = false;
	auto callback = [](void* data, int argc, char** argv, char** azColName)
	{
		*static_cast<bool*>(data) = true;
		return 0;
	};

	const std::string sqlCommand = "SELECT * FROM USERS WHERE NAME IS '" + uname + "'";
	char* errMessage = nullptr;
	const auto res = sqlite3_exec(_db, sqlCommand.c_str(), callback, &flag, &errMessage);
	if (res != SQLITE_OK)
	{
		std::cout << errMessage << std::endl;
	}

	return false;
}

auto SqliteDataBase::checkPassword(std::string uname, std::string pswd) -> bool
{
	bool flag = false;
	auto callback = [](void* data, int argc, char** argv, char** azColName)
	{
		*static_cast<bool*>(data) = true;
		return 0;
	};

	const std::string sqlCommand = "SELECT * FROM USERS WHERE NAME IS '" + uname + "' AND PASSWORD IS '" + pswd + "'";
	char* errMessage = nullptr;
	const auto res = sqlite3_exec(_db, sqlCommand.c_str(), callback, &flag, &errMessage);
	if (res != SQLITE_OK)
	{
		std::cout << errMessage << std::endl;
	}

	return false;
}

auto SqliteDataBase::addUser(std::string uname, std::string pswd, std::string email) -> void
{
	const std::string sqlCommand = "INSERT INTO USERS (NAME, EMAIL, PASSWORD) VALUES('" + uname + "', '" + pswd + "', '" + email + "');";
	char* errMessage = nullptr;
	const auto res = sqlite3_exec(_db, sqlCommand.c_str(), nullptr, nullptr, &errMessage);
	if (res != SQLITE_OK)
	{
		std::cout << errMessage << std::endl;
	}
}

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
