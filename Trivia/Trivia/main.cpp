#pragma comment (lib, "ws2_32.lib")

#include "WSAInitializer.h"
#include "Server.h"
#include <iostream>
#include <exception>
#include "Communicator.h"
#include "JsonResponsePacketSerializer.h"
#define EXIT "EXIT"

void getInput() {
	std::string clientInput = "";
	while (clientInput != EXIT) {
		std::cin >> clientInput;
	}
	exit(0);
}

int main()
{
	std::thread t(getInput);
	try
	{
		WSAInitializer wsaInit;
		Server myServer;
		myServer.run();
	}
	catch (const std::exception& e)
	{
		std::cout << "Error occured: " << e.what() << std::endl;
	}
	t.join();
	system("PAUSE");
	return 0;
}
