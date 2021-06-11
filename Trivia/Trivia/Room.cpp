#include "Room.h"

Room::Room(const RoomData& metaData) : m_metadata(metaData)
{
}

void Room::addUser(const LoggedUser& loggedUser)
{
	m_users.push_back(loggedUser);
}

void Room::removeUser(LoggedUser& loggedUser)
{
	for (auto it = m_users.begin(); it != m_users.end(); ++it)
	{
		if (loggedUser == *it)
		{
			m_users.erase(it);
		}
	}
}

std::vector<std::string> Room::getAllUsers() const
{
	std::vector<std::string> usersNames;
	for (const auto user : m_users)
	{
		usersNames.push_back(user.getUname());
	}
	return usersNames;
}

const unsigned int Room::getState() const
{
	return m_metadata.isActive;
}

const RoomData Room::getData() const
{
	return m_metadata;
}
