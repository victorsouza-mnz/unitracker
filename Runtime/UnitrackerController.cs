using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Unitracker.Tools
{
    public class UnitrackerController : MonoBehaviour
    {

        public bool AreaTracker;
        public string TagsToTrack;
        public string RoomName;

        void Start()
        {
            CSVHelper.init();
        }
        public void OnTriggerEnter(Collider other)
        {
            AreaTrackerHelper.TrackerArea(other, "Enter", RoomName);
        }

        public void OnTriggerExit(Collider other)
        {
            AreaTrackerHelper.TrackerArea(other, "Exit", RoomName);
        }
    }

}
