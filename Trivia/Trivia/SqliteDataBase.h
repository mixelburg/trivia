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
	/**
	 * @brief retrieves id of user by given username from database
	 * @param uname name of user to search for
	 * @return id of user
	*/
	int getUserId(const std::string& uname) const;

	/**
	 * @brief retrieves name of user by given user id from database
	 * @param id - id of user to search for
	 * @return name of user
	*/
	std::string getUserName(int id) const;

	sqlite3* _db;
	std::string _dbFilename = "db.sqlite";
};
