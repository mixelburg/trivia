#pragma once
#include <string>
#include "sqlite3.h"
#include "IDataBase.h"

class SqliteDataBase : IDataBase {
public:
	virtual ~SqliteDataBase() = default;

	auto isUser(const std::string& uname) const -> bool override;
	auto checkPassword(const std::string& uname, const std::string& pswd) const -> bool override;
	auto addUser(const std::string& uname, const std::string& pswd, const std::string& email) const -> void override;
	auto getQuestion(int num) const -> std::list<Question> override;
	auto getPlayerAverageAnswerTime(const std::string& uname) const -> float override;
	auto getNumOfCorrectAnswers(const std::string& uname) const -> int override;
	auto getNumOfTotalAnswers(const std::string& uname) const -> int override;
	auto getNumOfPlayerGames(const std::string& uname) const -> int override;
	
	auto open() -> bool override;
	void close() override;
private:
	auto getUserId(const std::string& uname) const -> int;
	
	sqlite3* _db;
	std::string _dbFilename = "db.sqlite";
};

