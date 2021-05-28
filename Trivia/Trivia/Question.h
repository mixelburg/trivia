#pragma once
#include <string>
#include <vector>

class Question
{
public:
	Question(const std::string& question, const std::vector<std::string>& answers, const int& answer)
		: _question(std::move(question)),
		  _answers(std::move(answers)),
		  _answer(answer)
	{
	}

	std::string getQuestion() const;
	void setQuestion(std::string question);
	std::vector<std::string> getAnswers() const;
	void setAnswers(std::vector<std::string> answers);
	int getAnswer() const;
	void setAnswer(const int answer);
private:
	std::string _question;
	std::vector<std::string> _answers;
	int _answer;
};
