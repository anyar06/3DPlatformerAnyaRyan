using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSensor : MonoBehaviour
{
    public MovingDoor Door3Dmodel;

    private void OnTriggerEnter(Collider other)
    {
      // if(other.tag == "Player")
       // {
            Door3Dmodel.isOpen = true;
            Debug.Log("Touched door");
      //  }
    }
}
