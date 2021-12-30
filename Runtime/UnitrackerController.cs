using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Unitracker.Tools
{
    public class UnitrackerController : MonoBehaviour
    {

        public bool AreaTracker;
        public string TagToTrack;
        public string RoomName;

        //Initializing the csv in order to store de spatial data
        void Start()
        {
            if (AreaTracker)
            {
                CSVHelper.initRoomEvents();
            }

            CSVHelper.initCustomEvents();

        }



        public void OnTriggerEnter(Collider other)
        {
            if (AreaTracker)
            {
                AreaTrackerHelper.TrackerArea(other, "Enter", RoomName, TagToTrack);
            }
        }

        public void OnTriggerExit(Collider other)
        {
            if (AreaTracker)
            {
                AreaTrackerHelper.TrackerArea(other, "Exit", RoomName, TagToTrack);
            }
        }
    }

}
