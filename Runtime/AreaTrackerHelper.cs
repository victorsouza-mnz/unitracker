using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Unitracker.Tools
{
    public static class AreaTrackerHelper
    {

        public static void TrackerArea(Collider other, string Action, string RoomName)
        {
            Debug.Log(other.gameObject.tag);
            if (other.gameObject.CompareTag("Player"))
            {
                CSVHelper.WriteCSVAreaLine(RoomName, Action);
            }
        }
    }
}