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


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        Invoke("pushIn", 0.5f);
        
    }

    private void OnTriggerExit(Collider other)
    {

        Invoke("pushOut", 1f);

    }

    void pushIn()
    {
        resettingCamera = false;
        inObject = true;
    }


    void pushOut()
    {
        inObject = false;
        resettingCamera = true;
    }



    // Update is called once per frame
    void Update()
    {

        if (inObject == true)
        {
            camTrans.position = Vector3.MoveTowards(camTrans.position, pullPoint.position, 0.2f);
        }


        if (resettingCamera == true)
        {
            camTrans.position = Vector3.MoveTowards(camTrans.position, cameraPoint.position, 1f);
        }
    }

}

