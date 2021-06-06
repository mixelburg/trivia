<<<<<<< HEAD
﻿using Newtonsoft.Json;
using System.Collections.Generic;
=======
﻿using System.Resources;
using Newtonsoft.Json;
>>>>>>> 06777027518b7fb0ac77a6f112944ad1a371c694

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
        ///     Function extract the status from the server response
        /// </summary>
        /// <param string with the server response="res"></param>
        /// <returns></returns>
        public static StatusStruct DeserializeStatusMsg(string msg)
        {
<<<<<<< HEAD
            res = res.Substring(startIndex);
            StatusStruct serverRes = JsonConvert.DeserializeObject<StatusStruct>(res);
=======
            return DeserializeMsg<StatusStruct>(msg);
        }

        public static StatsStruct DeserializeUserStatsMsg(string msg)
        {
            return DeserializeMsg<StatsStruct>(msg);
        }
>>>>>>> 06777027518b7fb0ac77a6f112944ad1a371c694

        public static ScoresStruct DeserializeScoresMsg(string msg)
        {
            return DeserializeMsg<ScoresStruct>(msg);
        }
        /// <summary>
        ///     Function extract the rooms from the server response
        /// </summary>
        /// <param string with the server response="res"></param>
        /// <returns></returns>
        public static RoomsStruct DeserializeRoomsMsg(ref string res) {
            res = res.Substring(startIndex);
            RoomsStruct serverRes = JsonConvert.DeserializeObject<RoomsStruct>(res);

            return serverRes;
        }
        public struct StatusStruct
        {
            public string status;
        }
<<<<<<< HEAD
        public struct RoomsStruct {
            public string status; 
            public List<string> roomsNames;
=======

        public struct StatsStruct
        {
            public string UserStatistics;
        }

        public struct ScoresStruct
        {
            public string HighScores;
>>>>>>> 06777027518b7fb0ac77a6f112944ad1a371c694
        }
    }
}