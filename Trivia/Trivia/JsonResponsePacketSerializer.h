#pragma once

#include <string>
#include <vector>
#include "Codes.h"
#include "Room.h"

#define NA 1

struct IStatusResponse
{
public:
	IStatusResponse(unsigned int status, unsigned char code) : status(status), code(code)
	{
	}

	unsigned int status;
	unsigned char code;
};

struct LoginResponse : public IStatusResponse
{
	LoginResponse(unsigned int status) : IStatusResponse(status, LOGIN_CODE)
	{
	}
};

struct SignupResponse : public IStatusResponse
{
	SignupResponse(unsigned int status) : IStatusResponse(status, SIGNUP_CODE)
	{
	}
};

struct ErrorResponse
{
	ErrorResponse(std::string message) : message(message)
	{
	}

	std::string message;
};

// strcuts for version 2 
struct LogoutResponse : public IStatusResponse
{
	LogoutResponse(unsigned int status) : IStatusResponse(status, LOGOUT_CODE)
	{
	}
};

struct GetRoomsResponse : public IStatusResponse
{
	GetRoomsResponse(unsigned int status, std::vector<RoomData> rooms) : IStatusResponse(status, GET_ROOMS_CODE),
	                                                                     rooms(rooms)
	{
	}

	std::vector<RoomData> rooms;
};

struct GetPlayersInRoomResponse : public IStatusResponse
{
	GetPlayersInRoomResponse(std::vector<std::string> players) : IStatusResponse(NA, GET_PLAYERS_CODE), players(players)
	{
	}

	std::vector<std::string> players;
};

struct GetHighScoreResponse : public IStatusResponse
{
	GetHighScoreResponse(unsigned int status, std::vector<std::string> highScore) :
		IStatusResponse(status, GET_HIGH_SCORE_CODE), highScore(highScore)
	{
	}

	std::vector<std::string> highScore;
};

struct GetPersonalStatsResponse : public IStatusResponse
{
	GetPersonalStatsResponse(unsigned int status, std::vector<std::string> statistics) :
		IStatusResponse(status, GET_STATS_CODE), statistics(statistics)
	{
	}

	std::vector<std::string> statistics;
};

struct JoinRoomResponse : public IStatusResponse
{
	JoinRoomResponse(unsigned int status) : IStatusResponse(status, JOIN_ROOM_CODE)
	{
	}
};

struct CreateRoomResponse : public IStatusResponse
{
	CreateRoomResponse(unsigned int status) : IStatusResponse(status, CREATE_ROOM_CODE)
	{
	}
};

class JsonResponsePacketSerializer
{
public:
	/*
	Function serialize the error response to buffer
	input: struct of the error response
	output: buffer with the error response
	*/
	static std::vector<unsigned char> serializeResponse(const ErrorResponse& errResponse);
	/*
	Function serialize the status response to buffer
	input: strcut of the status response
	output: buffer with the status response
	*/
	static std::vector<unsigned char> serializeResponse(const IStatusResponse& codeResponse);
	/*
	Function serialize the rooms response to buffer
	input: struct of the rooms response
	output: buffer with the rooms response
	*/
	static std::vector<unsigned char> serializeResponse(const GetRoomsResponse& roomsResponse);
	/*
	Function serialize the players response to buffer
	input: struct of the players response
	output: buffer with the players response
	*/
	static std::vector<unsigned char> serializeResponse(const GetPlayersInRoomResponse& playersResponse);
	/*
	Function serialize the stats response to buffer
	input: struct of the stats response
	output: buffer with the stats response
	*/
	static std::vector<unsigned char> serializeResponse(const GetPersonalStatsResponse& statsResponse);
	/*
	Function serialize the high scores response to buffer
	input: struct of the  high scores response
	output: buffer with the  high scores response
	*/
	static std::vector<unsigned char> serializeResponse(const GetHighScoreResponse& highScoresResponse);
};
