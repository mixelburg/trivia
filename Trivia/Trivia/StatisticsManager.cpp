#include "StatisticsManager.h"

StatisticsManager::StatisticsManager(IDataBase* dataBase) : _dataBase(dataBase)
{
}

std::vector<std::string> StatisticsManager::getStatistics()
{
	std::vector<std::string> stats;

	return stats;
}

std::vector<std::string> StatisticsManager::getHighScore()
{
	return _dataBase->getBestPlayers();
}

std::vector<std::string> StatisticsManager::getUserStatistics(const std::string& uname) const
{
	std::vector<std::string> stats;
	stats.emplace_back("avg answer time: " + std::to_string(_dataBase->getPlayerAverageAnswerTime(uname)));
	stats.emplace_back("answers: correct-" + std::to_string(_dataBase->getNumOfCorrectAnswers(uname))
		+ " total-" + std::to_string(_dataBase->getNumOfTotalAnswers(uname)));
	stats.emplace_back("total games: " + std::to_string(_dataBase->getNumOfPlayerGames(uname)));
	return stats;
}
