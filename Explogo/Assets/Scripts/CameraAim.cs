using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAim : MonoBehaviour
{
    public float mouseSensitivity = 3.0f; //Mouse sensitivity.
    public float viewRange = 60.0f;
    float rotVertical = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Camera

        float rotHorizontal = Input.GetAxisRaw("Mouse X") * mouseSensitivity;

        transform.Rotate(0, rotHorizontal, 0);


        rotVertical = Input.GetAxisRaw("Mouse Y") * mouseSensitivity;

        rotVertical = Mathf.Clamp(rotVertical, -viewRange, viewRange);

        Camera.main.transform.localRotation *= Quaternion.Euler(-rotVertical, 0, 0);
    }
}
