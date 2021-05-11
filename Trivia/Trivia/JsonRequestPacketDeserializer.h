#pragma once
#include "IRequestHandler.h"
#include "Codes.h"
#include <vector>
#include <string>

struct LoginRequest {
	std::string username;
	std::string password;
};

struct SignupRequest : LoginRequest{
	std::string email;
};

struct GetPlayersInRoomRequest {
	unsigned int roomId;
};

struct JoinRoomRequest {
	unsigned int roomId;
};

struct CreateRoomRequest {
	std::string roomName;
	unsigned int maxUsers;
	unsigned int questionCount;
	unsigned int answerTimeout;
};

class JsonRequestPacketDeserializer
{
public:
	/*
	Function deserialize a client request into LoginRequest 
	input: a buffer with the data of the request (json)
	output: login request struct
	*/
	static LoginRequest deserializeLoginRequest(const std::vector<unsigned char>& buffer);
	/*
	Function deserialize a client request into SignupRequest
	input: a buffer with the data of the request (json)
	output: signup request struct
	*/
	static SignupRequest deserializeSignupRequest(const std::vector<unsigned char>& buffer);
};

