#pragma once
#include "Question.h"
#include <list>

class IDataBase
{
public:
	virtual ~IDataBase() = default;

	virtual bool isUser(const std::string& uname) const = 0;
	virtual bool checkPassword(const std::string& uname, const std::string& pswd) const = 0;
	virtual void addUser(const std::string& uname, const std::string& pswd, const std::string& email) const = 0;
	virtual std::list<Question> getQuestion(int num) const = 0;
	virtual float getPlayerAverageAnswerTime(const std::string& uname) const = 0;
	virtual int getNumOfCorrectAnswers(const std::string& uname) const = 0;
	virtual int getNumOfTotalAnswers(const std::string& uname) const = 0;
	virtual int getNumOfPlayerGames(const std::string& uname) const = 0;
	virtual std::vector<std::string> getBestPlayers() const = 0;

	virtual bool open() = 0;
	virtual void close() = 0;
};
