using Newtonsoft.Json;

namespace GUI
{
    public struct LoginRequestData
    {
        public string username;
        public string password;
    }

    public struct SignupRequestData
    {
        public string username;
        public string password;
        public string mail;
    }

    public struct CreateRoomData
    {
        public string name;
        public int maxUsers;
        public int questionCount;
        public int answerTimeout;
    }

    public struct JoinRoomData
    {
        public int roomId;
    }

    public struct GetPlayersData
    {
        public int roomId;
    }


    internal class Serializer
    {
        public const int LengthSize = 4;

        private static string SerializeRequest<T>(ref T req, ref string code)
        {
            var request = code;
            var jsonData = JsonConvert.SerializeObject(req, Formatting.Indented);
            request += jsonData.Length.ToString().PadLeft(LengthSize, '0');
            request += jsonData;
            return request;
        }

        public static string SerializeLoginRequest(ref LoginRequestData loginReq)
        {
            return SerializeRequest(ref loginReq, ref codesClass.loginCode);
        }

        public static string SerializeSignupRequest(ref SignupRequestData signupReq)
        {
            return SerializeRequest(ref signupReq, ref codesClass.signupCode);
        }

        public static string SerializeCreateRoomRequest(ref CreateRoomData createRoomReq)
        {
            return SerializeRequest(ref createRoomReq, ref codesClass.createRoomCode);
        }

        public static string SerializeJoinRoomRequest(ref JoinRoomData joinRoomData)
        {
            return SerializeRequest(ref joinRoomData, ref codesClass.joinRoomCode);
        }

        public static string SerializeGetPlayersRequest(ref GetPlayersData getPlayersData)
        {
            return SerializeRequest(ref getPlayersData, ref codesClass.getPlayersCode);
        }

        private struct codesClass
        {
            public static string loginCode = "1";
            public static string signupCode = "2";
            public static string createRoomCode = "A";
            public static string joinRoomCode = "9";
            public static string getPlayersCode = "6";
        }
    }
}