#pragma once
#include "IDataBase.h"

class StatisticsManager
{
public:
	StatisticsManager() = default;
	~StatisticsManager() = default;
	
	std::vector<std::string> getStatistics();
private:
	auto getHighScore()->std::vector<std::string>;
	auto getUserStatistics(const std::string& uname) const ->std::vector<std::string>;
	IDataBase* _dataBase = nullptr;
};
