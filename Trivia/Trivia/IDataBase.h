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
	 * @brief returns list of questions from database
	 * @param num number of questions to get
	 * @return std::list with questions 
	*/
	virtual std::list<Question> getQuestion(int num) const = 0;

	/**
	 * @brief returns average answer time for a given player
	 * @param uname name of player to check
	 * @return float containing average answer time 
	*/
	virtual float getPlayerAverageAnswerTime(const std::string& uname) const = 0;

	/**
	 * @brief returns number of correct answers for a given player
	 * @param uname name of player to retrieve data from
	 * @return int containing number of correct answers
	*/
	virtual int getNumOfCorrectAnswers(const std::string& uname) const = 0;

	/**
	 * @brief returns number of total answers for a given player
	 * @param uname name of player to retrieve data from
	 * @return int containing number of correct answers
	*/
	virtual int getNumOfTotalAnswers(const std::string& uname) const = 0;

	/**
	 * @brief returns number of total played games for a given player
	 * @param uname name of player to retrieve data from
	 * @return int containing number of correct answers
	*/
	virtual int getNumOfPlayerGames(const std::string& uname) const = 0;

	/**
	 * @brief returns best players in the system by percent
	 * of correct answers
	 * @return std::vector of string representing players
	*/
	virtual std::vector<std::string> getBestPlayers() const = 0;

	/**
	 * @brief opens the database 
	 * @return true/false (succeeded or failed)
	*/
	virtual bool open() = 0;

	/**
	 * @brief closes the database
	*/
	virtual void close() = 0;
};
