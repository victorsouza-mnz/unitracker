using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace Unitracker.Tools
{
    public static class CSVHelper
    {
        static string filename = "";
        public static void init()
        {
            filename = Application.dataPath + "/teste.csv";
            TextWriter tw = new StreamWriter(filename, true);
            if (new FileInfo(filename).Length == 0)
            {
                tw.WriteLine("Action, Room Name, Time");
            }
            tw.Close();
        }

        public static void WriteCSVAreaLine(string areaName, string actionName)
        {
            TextWriter tw = new StreamWriter(filename, true);
            tw.WriteLine(actionName + "," + areaName + "," + Mathf.Floor(Time.time).ToString());
            tw.Close();
        }
    }
}