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
    public struct CreateRoomData {
        public string name;
        public int maxUsers;
        public int questionCount;
        public int answerTimeout;
    }
    class Serializer
    {
        /// <summary>
        /// Function serialize a login request to send the server
        /// </summary>
        /// <param Object of the login data="loginReq"></param>
        /// <returns> A string with the serialized request </returns>
        public const int LengthSize = 4;
        public static string SerializeLoginRequest(ref LoginRequestData loginReq) {
            string request = "1";
            string jsonData = JsonConvert.SerializeObject(loginReq, Formatting.Indented);
            request += jsonData.Length.ToString().PadLeft(LengthSize, '0');          
            request += jsonData;
            return request;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="signupReq"></param>
        /// <returns></returns>
        public static string SerializeSignupRequest(ref SignupRequestData signupReq) {
            string request = "2";
            string jsonData = JsonConvert.SerializeObject(signupReq, Formatting.Indented);
            request += jsonData.Length + jsonData;
            return request;
        }
        public static string SerializeCreateRoomRequest(ref CreateRoomData createRoomReq) {
            string request = "A";
            string jsonData = JsonConvert.SerializeObject(createRoomReq, Formatting.Indented);
            request += jsonData.Length.ToString().PadLeft(LengthSize, '0');
            request += jsonData;
            return request;
        }
    }
}
