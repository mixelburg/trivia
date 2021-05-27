using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace GUI
{
    class serializer
    {
        /// <summary>
        /// Function serialize a login request to send the server
        /// </summary>
        /// <param Object of the login data="loginReq"></param>
        /// <returns> A string with the serialized request </returns>
        public static string SerializeLoginRequest(LoginRequestData loginReq) {
            string request = "1";
            string jsonData = JsonConvert.SerializeObject(loginReq, Formatting.Indented);
            request += jsonData.Length + jsonData;
            return request;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="signupReq"></param>
        /// <returns></returns>
        public static string SerializeSignupRequest(SignupRequestData signupReq) {
            string request = "2";
            string jsonData = JsonConvert.SerializeObject(signupReq, Formatting.Indented);
            request += jsonData.Length + jsonData;
            return request;
        }
    }
}
