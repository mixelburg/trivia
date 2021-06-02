#pragma once
#include "Question.h"
#include <list>

class IDataBase
{
public:
	virtual ~IDataBase() = default;

	/**
	 * @brief checks if user exists in database
	 * @param uname name of user to check
	 * @return true/false
	*/
	virtual bool isUser(const std::string& uname) const = 0;

	/**
	 * @brief checks if password is correct
	 * @param uname name of user to check
	 * @param pswd password to check
	 * @return true/false
	*/
	virtual bool checkPassword(const std::string& uname, const std::string& pswd) const = 0;

	/**
	 * @brief adds user to the database
	 * @param uname name of user to add
	 * @param pswd password of user to add
	 * @param email email of uer to add
	*/
	virtual void addUser(const std::string& uname, const std::string& pswd, const std::string& email) const = 0;

	/**
	 * @brief 
	 * @param num 
	 * @return 
	*/
	virtual std::list<Question> getQuestion(int num) const = 0;
	virtual float getPlayerAverageAnswerTime(const std::string& uname) const = 0;
	virtual int getNumOfCorrectAnswers(const std::string& uname) const = 0;
	virtual int getNumOfTotalAnswers(const std::string& uname) const = 0;
	virtual int getNumOfPlayerGames(const std::string& uname) const = 0;
	virtual std::vector<std::string> getBestPlayers() const = 0;

	virtual bool open() = 0;
	virtual void close() = 0;
};
