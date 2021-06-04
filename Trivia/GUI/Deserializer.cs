using System.Resources;
using Newtonsoft.Json;

namespace GUI
{
    internal class Deserializer
    {
        public const int startIndex = 5;

        public static T DeserializeMsg<T>(string msg)
        {
            msg = msg.Substring(startIndex);
            return JsonConvert.DeserializeObject<T>(msg);
        }

        /// <summary>
        ///     Function extract the status for the server response
        /// </summary>
        /// <param string with the server response="res"></param>
        /// <returns></returns>
        public static StatusStruct DeserializeStatusMsg(string msg)
        {
            return DeserializeMsg<StatusStruct>(msg);
        }

        public static UserStatsStruct DeserializeUserStatsMsg(string msg)
        {
            return DeserializeMsg<UserStatsStruct>(msg);
        }

        public struct StatusStruct
        {
            public string status;
        }

        public struct UserStatsStruct
        {
            public string UserStatistics;
        }
    }
}