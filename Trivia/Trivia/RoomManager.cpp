#include "RoomManager.h"

void RoomManager::createRoom(const LoggedUser& owner, RoomData& roomData)
{
	roomData.id = m_currRoomId++;
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

std::vector<RoomData> RoomManager::getRooms()
{
	std::vector<RoomData> roomsData;
	for (const auto& room : m_rooms) {
		roomsData.push_back(room.second.getData());
	}
	return roomsData;
}

void RoomManager::addUser(const LoggedUser& user, const int roomId)
{
	for (auto& pair: m_rooms)
	{
		if (pair.first == roomId)
		{
			pair.second.addUser(user);
		}
	}
}

const std::vector<std::string> RoomManager::getAllUsers(const int id)
{
	for (const auto& pair : m_rooms)
	{
		if (pair.first == id) return pair.second.getAllUsers();
	}
	
	return std::vector<std::string>();
}
