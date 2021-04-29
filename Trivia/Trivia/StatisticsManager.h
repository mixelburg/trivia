#pragma once
#include "IDataBase.h"

class StatisticsManager
{
public:
	auto getStatistics()->std::vector<std::string>;
private:
	auto getHighScore()->std::vector<std::string>;
	auto getUserStatistics(const std::string& uname) const ->std::vector<std::string>;
	IDataBase* _dataBase;
};
