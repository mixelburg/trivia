using Newtonsoft.Json;
using System.Collections.Generic;
﻿using System.Resources;
using Newtonsoft.Json;
using System;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Windows;
using System.Collections.Generic;

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
            return DeserializeMsg<StatusStruct>(msg);
        }

        public static StatsStruct DeserializeUserStatsMsg(string msg)
        {
            return DeserializeMsg<StatsStruct>(msg);
        }

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
            Console.WriteLine(res);
            RoomsStruct serverRes = JsonConvert.DeserializeObject<RoomsStruct>(res);

            return serverRes;
        }
        public static PlayersStruct DeserializePlayersMsg(ref string res) {
            res = res.Substring(startIndex);
            PlayersStruct serverRes = JsonConvert.DeserializeObject<PlayersStruct>(res);
            return serverRes;
        }
        public static RoomIdStruct DeserializeRoomMsg(ref string res) {
            res = res.Substring(startIndex);
            RoomIdStruct serverRes = JsonConvert.DeserializeObject<RoomIdStruct>(res);
            return serverRes;
        }
        public struct StatsStruct
        {
            public string UserStatistics;
        }
        public struct StatusStruct
        {
            public string status;
        }
        public struct RoomsStruct
        {
            public string status;
            public string roomsNames;
            public string roomsIds;
        }

        public struct ScoresStruct
        {
            public string HighScores;
        }
        public struct PlayersStruct {
            public string PlayersInRoom;
        }
        public struct RoomIdStruct {
            public string status;
            public int roomId;
        }
    }
}