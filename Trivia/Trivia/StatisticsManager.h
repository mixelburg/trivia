#pragma once
#include "IDataBase.h"

class StatisticsManager
{
public:
	StatisticsManager(IDataBase* dataBase);
	~StatisticsManager() = default;

	/**
	 * @brief returns statistics of users in the system
	 * @return std::vector with strings containing statistics
	*/
	std::vector<std::string> getStatistics();

	/**
	 * @brief returns highest scores in the system
	 * @return std::vector with strings containing highest scores
	*/
	std::vector<std::string> getHighScore();

	/**
	 * @brief returns statistics of a user with given username
	 * @param uname username of user to retrieve data from
	 * @return std::vector with strings containing statistics
	*/
	std::vector<std::string> getUserStatistics(const std::string& uname) const;
private:
	IDataBase* _dataBase = nullptr;
};
