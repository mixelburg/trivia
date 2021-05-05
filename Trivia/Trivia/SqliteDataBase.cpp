#pragma once

#include "SqliteDataBase.h"

#include <iostream>

auto SqliteDataBase::isUser(const std::string& uname) const -> bool
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

	return flag;
}

auto SqliteDataBase::checkPassword(const std::string& uname, const std::string& pswd) const -> bool
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

	return flag;
}

auto SqliteDataBase::addUser(const std::string& uname, const std::string& pswd, const std::string& email) const -> void
{
	const std::string sqlCommand = "INSERT INTO USERS (NAME, EMAIL, PASSWORD) VALUES('" + uname + "', '" + pswd + "', '" + email + "');";
	char* errMessage = nullptr;
	const auto res = sqlite3_exec(_db, sqlCommand.c_str(), nullptr, nullptr, &errMessage);
	if (res != SQLITE_OK)
	{
		std::cout << errMessage << std::endl;
	}
}

auto SqliteDataBase::getQuestion(const int num) const -> std::list<Question>
{
	std::list<Question> questions;
	auto callback = [](void* data, int argc, char** argv, char** azColName)
	{
		std::vector<std::string> answers;
		for (int i = 1; i <= 4; ++i)
		{
			answers.emplace_back(argv[i]);
		}
		static_cast<std::list<Question>*>(data)->push_back(Question(argv[0], answers, std::stoi(argv[5])));
		return 0;
	};

	const std::string sqlCommand = "SELECT * FROM QUESTIONS LIMIT " + std::to_string(num) + ";";
	char* errMessage = nullptr;
	const auto res = sqlite3_exec(_db, sqlCommand.c_str(), callback, &questions, &errMessage);
	if (res != SQLITE_OK)
	{
		std::cout << errMessage << std::endl;
	}

	return questions;
}

auto SqliteDataBase::getPlayerAverageAnswerTime(const std::string& uname) const -> float
{
	int avgTime = false;
	auto callback = [](void* data, int argc, char** argv, char** azColName)
	{
		*static_cast<int*>(data) = std::stoi(argv[0]);
		return 0;
	};

	const std::string sqlCommand = "SELECT AVG_ANSWER_TIME FROM STATISTICS WHERE USER_ID is " + std::to_string() + ";";
	char* errMessage = nullptr;
	const auto res = sqlite3_exec(_db, sqlCommand.c_str(), callback, &flag, &errMessage);
	if (res != SQLITE_OK)
	{
		std::cout << errMessage << std::endl;
	}

	return avgTime;
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

auto SqliteDataBase::getUserId(const std::string& uname) const -> int
{
	int userId = false;
	auto callback = [](void* data, int argc, char** argv, char** azColName)
	{
		*static_cast<int*>(data) = std::stoi(argv[0]);
		return 0;
	};

	const std::string sqlCommand = "SELECT ID FROM USERS WHERE NAME IS '" + uname + "';";
	char* errMessage = nullptr;
	const auto res = sqlite3_exec(_db, sqlCommand.c_str(), callback, &userId, &errMessage);
	if (res != SQLITE_OK)
	{
		std::cout << errMessage << std::endl;
	}

	return userId;
}
