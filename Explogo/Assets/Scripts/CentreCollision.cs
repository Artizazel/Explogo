using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentreCollision : MonoBehaviour
{

    public GameObject nitro;

    int inObj = 0;


    //Script used for forcing the player out of geometry if they get stuck


        //For as long as the player is stuck in geometry inObj will constantly count up every tick until it forces the player upwards and resets
    void OnTriggerStay()
    {

        inObj++;


        if (inObj == 10)
        {
            nitro.transform.Translate(transform.up * 10);
            inObj = 0;
        }
    }


    //Will reset the inObj counter so it doesn't stay above 0 when out of geometry
    void OnTriggerExit()
    {

        inObj = 0;

    }

    void Update()
    {
        
    }
}
