#include "RoomManager.h"

void RoomManager::createRoom(const LoggedUser& owner, const RoomData& roomData)
{
	Room newRoom(roomData);
	newRoom.addUser(owner);
	m_rooms.emplace(std::make_pair(roomData.id, newRoom));
}
