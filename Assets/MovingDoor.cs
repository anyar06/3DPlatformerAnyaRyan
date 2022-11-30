using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingDoor : MonoBehaviour
{
    public bool isOpen = false;

    public Transform Door3Dmodel;
    public Transform startingPoint;
    public Transform endingPoint;
    
    private void Start()
    {
        Door3Dmodel.position = startingPoint.position;
    }

    private void Update()
    {
        if (isOpen == private void OnRenderImage(RenderTexture src, RenderTexture dest) {
        {
            Door3Dmodel.position = Vector3.MoveTowards(Door3Dmodel.position, endingPoint.position, Time.deltaTime);
        }
    }
}
