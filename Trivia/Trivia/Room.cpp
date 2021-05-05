#include "Room.h"

void Room::addUser(const LoggedUser& loggedUser)
{
	m_users.push_back(loggedUser);
}

void Room::removeUser(const LoggedUser& loggedUser)
{
	for (auto it = m_users.begin(); it != m_users.end(); ++it) {
		/*if (loggedUser == *it) {
			m_users.erase(it);
		}*/
	}
}
