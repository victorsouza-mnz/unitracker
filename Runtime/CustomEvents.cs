using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Unitracker.Tools
{


    public static class CustomEvents
    {
        public static void TrackEvent(string EventName, string Actor = "", string Value = "", string location = "")
        {
            CSVHelper.WriteCSVCustomEventLine(EventName, Actor, Value, location);
        }
    }
}
