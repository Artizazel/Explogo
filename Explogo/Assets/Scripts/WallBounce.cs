using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBounce : MonoBehaviour
{

    public GameObject bounceScript;

   
    //If the main body of the player (not the bottom) hits any other object it will tell the movement script that to reset the cooldown on 'JumpBoost'
    private void OnTriggerEnter(Collider other)
    {


        bounceScript.SendMessage("hitWall");


    }
    
}
