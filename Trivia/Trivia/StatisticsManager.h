#pragma once
#include "IDataBase.h"

class StatisticsManager
{
public:
	StatisticsManager(IDataBase* dataBase);
	~StatisticsManager() = default;

	std::vector<std::string> getStatistics();
	std::vector<std::string> getHighScore();
	std::vector<std::string> getUserStatistics(const std::string& uname) const;
private:
	IDataBase* _dataBase = nullptr;
};
