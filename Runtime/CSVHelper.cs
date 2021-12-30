using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace Unitracker.Tools
{
    public static class CSVHelper
    {
        static string filenameRoomEvents = "";
        static string filenameCustomEvents = "";
        public static void initRoomEvents()
        {
            filenameRoomEvents = Application.dataPath + "/RoomsEvents.csv";
            TextWriter tw = new StreamWriter(filenameRoomEvents, true);
            if (new FileInfo(filenameRoomEvents).Length == 0)
            {
                tw.WriteLine("Action, Room Name, Time");
            }
            tw.Close();
        }

        public static void initCustomEvents()
        {
            filenameCustomEvents = Application.dataPath + "/CustomEvents.csv";
            TextWriter tw = new StreamWriter(filenameCustomEvents, true);
            if (new FileInfo(filenameCustomEvents).Length == 0)
            {
                tw.WriteLine("Event, Actor, Value, Location, Time");
            }
            tw.Close();
        }

        public static void WriteCSVAreaLine(string areaName, string actionName)
        {
            TextWriter tw = new StreamWriter(filenameRoomEvents, true);
            tw.WriteLine(actionName + "," + areaName + "," + Mathf.Floor(Time.time).ToString());
            tw.Close();
        }

        public static void WriteCSVCustomEventLine(string eventName, string actor, string value, string location)
        {
            TextWriter tw = new StreamWriter(filenameCustomEvents, true);
            tw.WriteLine(eventName + "," + actor + "," + value + "," + location + "," + Mathf.Floor(Time.time).ToString());
            tw.Close();
        }


    }
}