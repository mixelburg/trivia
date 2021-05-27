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
        /// <param username="uname"></param>
        /// <param password="pass"></param>
        /// <returns> A string with the serialized request </returns>
        public static string SerializeLoginRequest(LoginRequest loginReq) {
            string request = JsonConvert.SerializeObject(loginReq, Formatting.Indented);
            return request;
        }
    }
}
