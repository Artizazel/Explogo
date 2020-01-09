using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPull : MonoBehaviour
{


    public Transform camTrans;

    public Transform cameraPoint;

    public Transform pullPoint;

    private float shiftVal = 5000;

    private Vector3 startPosition;

    bool inObject = false;

    bool resettingCamera = false;




    //Script for pulling the camera out of geometry closer to the player and back


    
    private void OnTriggerEnter(Collider other)
    {

        Invoke("pushIn", 0.5f);
        
    }

    private void OnTriggerExit(Collider other)
    {

        Invoke("pushOut", 1f);

    }


    //Is called briefly after the camera point collides with any geometry, puts the script in a 'push in' state using booleans
    void pushIn()
    {
        resettingCamera = false;
        inObject = true;
    }

    //Is called briefly after the camera point exits with any geometry, puts the script in a 'push out' state using booleans
    void pushOut()
    {
        inObject = false;
        resettingCamera = true;
    }



    void Update()
    {

        //Gradually moves the main camera to the pull point (closer to the player) 
        if (inObject == true)
        {
            camTrans.position = Vector3.MoveTowards(camTrans.position, pullPoint.position, 0.2f);
        }

        //Gradually moves the main camera to the camera point (away from the player)
        if (resettingCamera == true)
        {
            camTrans.position = Vector3.MoveTowards(camTrans.position, cameraPoint.position, 1f);
        }
    }

}

