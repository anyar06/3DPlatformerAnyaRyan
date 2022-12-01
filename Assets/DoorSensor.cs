using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSensor : MonoBehaviour
{
    public MovingDoor myDoor;

    private void OnTriggorEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            myDoor.isOpen = true;
        }
    }
}
