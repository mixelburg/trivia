#pragma once
#include "Question.h"
#include <list>

class IDataBase {
public:
	virtual ~IDataBase() = default;

	virtual auto isUser(const std::string& uname) const -> bool = 0;
	virtual auto checkPassword(const std::string& uname, const std::string& pswd) const -> bool = 0;
	virtual auto addUser(const std::string& uname, const std::string& pswd, const std::string& email) const -> void = 0;
	virtual auto getQuestion(int num) const->std::list<Question> = 0;
	virtual auto getPlayerAverageAnswerTime(const std::string& uname) const -> float = 0;
	virtual auto getNumOfCorrectAnswers(const std::string& uname) const -> int = 0;
	virtual auto getNumOfTotalAnswers(const std::string& uname) const -> int = 0;
	virtual auto getNumOfPlayerGames(const std::string& uname) const -> int = 0;
	virtual auto getBestPlayers() const->std::vector<std::string> = 0;

	virtual bool open() = 0;
	virtual void close() = 0;
};
