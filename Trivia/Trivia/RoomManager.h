#pragma once
#include "LoggedUser.h"
#include "Room.h"
#include <vector>
#include <map>

class RoomManager
{
public:
	/*
	Function creats a room
	input: a logged user who creats the room, the room data
	output: none
	*/
	int createRoom(const LoggedUser& owner, RoomData& roomData);
	/*
	Function deletes a room
	input: the id of the room to be deleted
	output: none
	*/
	void deleteRoom(int id);
	/*
	Function returns the room state
	input: the id of the room
	output: the state
	*/
	unsigned int getRoomState(int id);
	/*
	Function returns all the rooms
	input: none
	output: vector with the rooms (room's data)
	*/
	std::vector<RoomData> getRooms();

	/**
	 * @brief adds user to a list of connected users in a room with given id
	 * @param user LoggedUser object to add
	 * @param roomId id of room to add user to
	*/
	void addUser(const LoggedUser& user, int roomId);

	/**
	 * @brief returns list of connected users in a room with given id
	 * @param id - id of room to retrieve data from
	 * @return std::vector with usernames
	*/
	const std::vector<std::string> getAllUsers(int id);
private:
	std::map<unsigned int, Room> m_rooms; // a map with the rooms
	int m_currRoomId = 0;
};
