using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentreCollision : MonoBehaviour
{

    public GameObject nitro;

    int inObj = 0;


    // Start is called before the first frame update
    void Start()
    {
        
}

    void OnTriggerStay()
    {

        inObj++;


        if (inObj == 10)
        {
            nitro.transform.Translate(transform.up * 10);
        }
    }

    void OnTriggerExit()
    {

        inObj = 0;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
