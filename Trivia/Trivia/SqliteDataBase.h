#pragma once
#include <string>
#include "sqlite3.h"
#include "IDataBase.h"

class SqliteDataBase : public IDataBase
{
public:
	~SqliteDataBase() override = default;

	bool isUser(const std::string& uname) const override;
	bool checkPassword(const std::string& uname, const std::string& pswd) const override;
	void addUser(const std::string& uname, const std::string& pswd, const std::string& email) const override;
	std::list<Question> getQuestion(int num) const override;
	float getPlayerAverageAnswerTime(const std::string& uname) const override;
	int getNumOfCorrectAnswers(const std::string& uname) const override;
	int getNumOfTotalAnswers(const std::string& uname) const override;
	int getNumOfPlayerGames(const std::string& uname) const override;
	std::vector<std::string> getBestPlayers() const override;

	bool open() override;
	void close() override;
private:
	int getUserId(const std::string& uname) const;
	std::string getUserName(int id) const;

	sqlite3* _db;
	std::string _dbFilename = "db.sqlite";
};
