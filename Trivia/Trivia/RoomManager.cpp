#include "RoomManager.h"

void RoomManager::createRoom(const LoggedUser& owner, const RoomData& roomData)
{
	Room newRoom(roomData);
	newRoom.addUser(owner);
	m_rooms.emplace(std::make_pair(roomData.id, newRoom));
}

void RoomManager::deleteRoom(const int id)
{
	m_rooms.erase(id);
}

unsigned int RoomManager::getRoomState(const int id)
{
	return m_rooms.find(id)->second.getState();
}

const std::vector<RoomData> RoomManager::getRooms()
{
	std::vector<RoomData> roomsData;
	for (const auto room : m_rooms) {
		roomsData.push_back(room.second.getData());
	}
	return roomsData;
}
