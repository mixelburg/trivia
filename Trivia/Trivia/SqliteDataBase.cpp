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
	const std::string sqlCommand = "INSERT INTO USERS (NAME, PASSWORD, EMAIL) VALUES('" + uname + "', '" + pswd + "', '" + email + "');";
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

	const std::string sqlCommand = "SELECT AVG_ANSWER_TIME FROM STATISTICS WHERE USER_ID is " + std::to_string(getUserId(uname)) + ";";
	char* errMessage = nullptr;
	const auto res = sqlite3_exec(_db, sqlCommand.c_str(), callback, &avgTime, &errMessage);
	if (res != SQLITE_OK)
	{
		std::cout << errMessage << std::endl;
	}

	return avgTime;
}

auto SqliteDataBase::getNumOfCorrectAnswers(const std::string& uname) const -> int
{
	int numCorrectAnswers = false;
	auto callback = [](void* data, int argc, char** argv, char** azColName)
	{
		*static_cast<int*>(data) = std::stoi(argv[0]);
		return 0;
	};

	const std::string sqlCommand = "SELECT NUM_ANSWERS_CORRECT FROM STATISTICS WHERE USER_ID is " + std::to_string(getUserId(uname)) + ";";
	char* errMessage = nullptr;
	const auto res = sqlite3_exec(_db, sqlCommand.c_str(), callback, &numCorrectAnswers, &errMessage);
	if (res != SQLITE_OK)
	{
		std::cout << errMessage << std::endl;
	}

	return numCorrectAnswers;
}

auto SqliteDataBase::getNumOfTotalAnswers(const std::string& uname) const -> int
{
	int numAnswers = false;
	auto callback = [](void* data, int argc, char** argv, char** azColName)
	{
		*static_cast<int*>(data) = std::stoi(argv[0]);
		return 0;
	};


	const std::string sqlCommand = "SELECT NUM_ANSWERS FROM STATISTICS WHERE USER_ID is " + std::to_string(getUserId(uname)) + ";";
	char* errMessage = nullptr;
	const auto res = sqlite3_exec(_db, sqlCommand.c_str(), callback, &numAnswers, &errMessage);
	if (res != SQLITE_OK)
	{
		std::cout << errMessage << std::endl;
	}

	return numAnswers;
}

auto SqliteDataBase::getNumOfPlayerGames(const std::string& uname) const -> int
{
	int numGames = false;
	auto callback = [](void* data, int argc, char** argv, char** azColName)
	{
		*static_cast<int*>(data) = std::stoi(argv[0]);
		return 0;
	};


	const std::string sqlCommand = "SELECT NUM_GAMES FROM STATISTICS WHERE USER_ID is " + std::to_string(getUserId(uname)) + ";";
	char* errMessage = nullptr;
	const auto res = sqlite3_exec(_db, sqlCommand.c_str(), callback, &numGames, &errMessage);
	if (res != SQLITE_OK)
	{
		std::cout << errMessage << std::endl;
	}

	return numGames;
}

auto SqliteDataBase::getBestPlayers() const -> std::vector<std::string>
{
	std::vector<std::string> list;

	std::vector<std::pair<int, std::string>> temp;
	auto callback = [](void* data, int argc, char** argv, char** azColName)
	{
		std::pair<int, std::string> p(std::stoi(argv[0]), argv[1]);
		static_cast<std::vector<std::pair<int, std::string>>*>(data)->emplace_back(p);
		return 0;
	};

	const std::string sqlCommand = "SELECT USER_ID, NUM_ANSWERS_CORRECT FROM STATISTICS ORDER BY NUM_ANSWERS_CORRECT DESC LIMIT 5;";
	char* errMessage = nullptr;
	const auto res = sqlite3_exec(_db, sqlCommand.c_str(), callback, &temp, &errMessage);
	if (res != SQLITE_OK)
	{
		std::cout << errMessage << std::endl;
	}

	for (const auto& p : temp)
	{
		list.emplace_back(p.second + ": " + getUserName(p.first));
	}

	return list;
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
	int userId = -1;
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

auto SqliteDataBase::getUserName(const int id) const -> std::string
{
	std::string uname;
	auto callback = [](void* data, int argc, char** argv, char** azColName)
	{
		*static_cast<std::string*>(data) = argv[0];
		return 0;
	};

	const std::string sqlCommand = "SELECT NAME FROM USERS WHERE ID IS " + std::to_string(id) + ";";
	char* errMessage = nullptr;
	const auto res = sqlite3_exec(_db, sqlCommand.c_str(), callback, &uname, &errMessage);
	if (res != SQLITE_OK)
	{
		std::cout << errMessage << std::endl;
	}

	return uname;
}

