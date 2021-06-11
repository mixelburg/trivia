#pragma once

#include <vector>
#include <string>
#include <WinSock2.h>


enum MessageType : byte
{
	//here we need to enter the new codes for the server
	MT_CLIENT_LOG_IN = 200,
	MT_CLIENT_UPDATE = 204,
	MT_CLIENT_FINISH = 207,
	MT_CLIENT_EXIT = 208,
	MT_SERVER_UPDATE = 101,
};


class Helper
{
public:
	/**
	 * @brief retrieves message code from a given socket
	 * @param sc SOCKET to retrieve data from
	 * @return int with message code
	*/
	static int getMessageTypeCode(SOCKET sc);

	/**
	 * @brief returns given number of bytes from socket
	 * and converts them into int
	 * @param sc SOCKET to retrieve data from
	 * @param bytesNum num of bytes to retrieve
	 * @return int with data
	*/
	static int getIntPartFromSocket(SOCKET sc, int bytesNum);

	/**
	 * @brief returns given number of bytes from socket
	 * and converts them into string
	 * @param sc SOCKET to retrieve data from
	 * @param bytesNum num of bytes to retrieve
	 * @return string with data
	*/
	static std::string getStringPartFromSocket(SOCKET sc, int bytesNum);

	/**
	 * @brief sends given string using given socket
	 * @param sc SOCKET to send data form
	 * @param message string with message to send
	*/
	static void sendData(SOCKET sc, std::string message);

	/**
	 * @brief returns string with padded number
	 * for example if num=44, digits=5
	 * function will return "00044"
	 * @param num given number to add padding to
	 * @param digits size of padding
	 * @return string with padded number
	*/
	static std::string getPaddedNumber(int num, int digits);

private:
	static char* getPartFromSocket(SOCKET sc, int bytesNum);
	static char* getPartFromSocket(SOCKET sc, int bytesNum, int flags);
};


#ifdef _DEBUG // vs add this define in debug mode
#include <stdio.h>
// Q: why do we need traces ?
// A: traces are a nice and easy way to detect bugs without even debugging
// or to understand what happened in case we miss the bug in the first time
#define TRACE(msg, ...) printf(msg "\n", __VA_ARGS__);
// for convenient reasons we did the traces in stdout
// at general we would do this in the error stream like that
// #define TRACE(msg, ...) fprintf(stderr, msg "\n", __VA_ARGS__);

#else // we want nothing to be printed in release version
#define TRACE(msg, ...) printf(msg "\n", __VA_ARGS__);
#define TRACE(msg, ...) // do nothing
#endif
