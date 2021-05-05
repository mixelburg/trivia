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
	void createRoom(const LoggedUser& owner, const RoomData& roomData);
	/*
	Function deletes a room
	input: the id of the room to be deleted
	output: none
	*/
	void deleteRoom(const int id);
	/*
	Function returns the room state
	input: the id of the room
	output: the state
	*/
	unsigned int getRoomState(const int id);
	/*
	Function returns all the rooms
	input: none
	output: vector with the rooms (room's data)
	*/
	const std::vector<RoomData> getRooms();
private:

	std::map<unsigned int, Room> m_rooms; // a map with the rooms
};

