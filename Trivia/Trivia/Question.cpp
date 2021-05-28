#include "Question.h"


std::string Question::getQuestion() const
{
	return _question;
}

void Question::setQuestion(std::string question)
{
	_question = std::move(question);
}

std::vector<std::string> Question::getAnswers() const
{
	return _answers;
}

void Question::setAnswers(std::vector<std::string> answers)
{
	_answers = std::move(answers);
}

int Question::getAnswer() const
{
	return _answer;
}

void Question::setAnswer(const int answer)
{
	_answer = answer;
}
