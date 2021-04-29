#include "StatisticsManager.h"

auto StatisticsManager::getStatistics() -> std::vector<std::string>
{
	std::vector<std::string> stats;
	
	return stats;
}

auto StatisticsManager::getHighScore() -> std::vector<std::string>
{
	std::vector<std::string> scores;
	
	return scores;
}

auto StatisticsManager::getUserStatistics(const std::string& uname) const -> std::vector<std::string>
{
	std::vector<std::string> stats;
	stats.emplace_back("avg answer time: " + std::to_string(_dataBase->getPlayerAverageAnswerTime(uname)));
	stats.emplace_back("answers: correct-" + std::to_string(_dataBase->getNumOfCorrectAnswers(uname))
		+ " total-" + std::to_string(_dataBase->getNumOfTotalAnswers(uname)));
	stats.emplace_back("total games: " + std::to_string(_dataBase->getNumOfPlayerGames(uname)));
	return stats;
}
