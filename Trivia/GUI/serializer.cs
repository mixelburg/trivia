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

    class Serializer
    {
        /// <summary>
        /// Function serialize a login request to send the server
        /// </summary>
        /// <param Object of the login data="loginReq"></param>
        /// <returns> A string with the serialized request </returns>
        public const int LengthSize = 4;
        struct codesClass {
            public static string loginCode = "1";
            public static string signupCode = "2";
        }
        public static string SerializeLoginRequest(LoginRequestData loginReq) {
            string request = codesClass.loginCode;
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
        public static string SerializeSignupRequest(SignupRequestData signupReq) {
            string request = codesClass.signupCode;
            string jsonData = JsonConvert.SerializeObject(signupReq, Formatting.Indented);
            request += jsonData.Length + jsonData;
            return request;
        }
    }
}
