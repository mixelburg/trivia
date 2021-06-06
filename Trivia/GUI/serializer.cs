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

        /// <summary>
        /// serializes general request 
        /// </summary>
        /// <typeparam name="T">struct to serialize</typeparam>
        /// <param name="req">request that will be serialized</param>
        /// <param name="code">request code</param>
        /// <returns>string with serialized request</returns>
        private static string SerializeRequest<T>(ref T req, ref string code)
        {
            var request = code;
            var jsonData = JsonConvert.SerializeObject(req, Formatting.Indented);
            request += jsonData.Length.ToString().PadLeft(LengthSize, '0');
            request += jsonData;
            return request;
        }

        /// <summary>
        /// specifically serializes login request 
        /// </summary>
        /// <param name="req">struct with login request params</param>
        /// <returns>string with serialized request</returns>
        public static string SerializeLoginRequest(ref LoginRequestData req)
        {
            return SerializeRequest(ref req, ref CodesClass.loginCode);
        }

        /// <summary>
        /// specifically serializes signup request 
        /// </summary>
        /// <param name="req">struct with signup request params</param>
        /// <returns>string with serialized request</returns>
        public static string SerializeSignupRequest(ref SignupRequestData req)
        {
            return SerializeRequest(ref req, ref CodesClass.signupCode);
        }

        /// <summary>
        /// specifically serializes create room request 
        /// </summary>
        /// <param name="req">struct with create room request params</param>
        /// <returns>string with serialized request</returns>
        public static string SerializeCreateRoomRequest(ref CreateRoomData req)
        {
            return SerializeRequest(ref req, ref CodesClass.createRoomCode);
        }

        /// <summary>
        /// specifically serializes join room request 
        /// </summary>
        /// <param name="req">struct with join room request params</param>
        /// <returns>string with serialized request</returns>
        public static string SerializeJoinRoomRequest(ref JoinRoomData req)
        {
            return SerializeRequest(ref req, ref CodesClass.joinRoomCode);
        }

        /// <summary>
        /// specifically serializes get players request 
        /// </summary>
        /// <param name="req">struct with get players request params</param>
        /// <returns>string with serialized request</returns>
        public static string SerializeGetPlayersRequest(ref GetPlayersData req)
        {
            return SerializeRequest(ref req, ref CodesClass.getPlayersCode);
        }
    }

    public struct CodesClass
    {
        public static string loginCode = "1";
        public static string signupCode = "2";
        public static string createRoomCode = "A";
        public static string joinRoomCode = "9";
        public static string getPlayersCode = "6";
        public static string getStatsCode = "8";
        public static string getHighScoreCode = "7";
        public static string getRoomsCode = "5";

    }
}