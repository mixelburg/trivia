#pragma once
#include "IDataBase.h"

class StatisticsManager
{
public:
	StatisticsManager() = default;
	~StatisticsManager() = default;
	
	std::vector<std::string> getStatistics();
	auto getHighScore()->std::vector<std::string>;
	auto getUserStatistics(const std::string& uname) const->std::vector<std::string>;
private:
	
	IDataBase* _dataBase = nullptr;
};
