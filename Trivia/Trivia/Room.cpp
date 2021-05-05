#include "Room.h"

void Room::addUser(const LoggedUser& loggedUser)
{
	m_users.push_back(loggedUser);
}
