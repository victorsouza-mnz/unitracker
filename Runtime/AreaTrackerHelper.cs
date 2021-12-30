using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Unitracker.Tools
{
    public static class AreaTrackerHelper
    {

        public static void TrackerArea(Collider other, string Action, string RoomName, string TagToTracker)
        {
            if (other.gameObject.CompareTag(TagToTracker))
            {
                CSVHelper.WriteCSVAreaLine(RoomName, Action);
            }
        }
    }
}