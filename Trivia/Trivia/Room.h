#pragma once

#include <string>
#include <vector>
#include "LoggedUser.h"

struct RoomData {
	unsigned int id;
	std::string name;
	unsigned int maxPlayers;
	unsigned int numOfQuestionsInGame;
	unsigned int timePerQuestion;
	unsigned int isActive;
};

class Room
{
private:
	RoomData m_metadata;
	std::vector<LoggedUser> m_users;

public:
	/*
	Function adds a user to the room
	input: the user
	output: none
	*/
	void addUser(const LoggedUser& loggedUser);
	/*
	Function removes a user from the room
	input: the user
	output: none
	*/
	void removeUser(LoggedUser& loggedUser);
	/*
	Function gets all the users from the room
	input: none
	output: the names of the users
	*/
	std::vector<std::string> getAllUsers();

};

