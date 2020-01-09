using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetect : MonoBehaviour
{

    public GameObject enemy;

    
    //If the player comes into contact with the enemy's detection sphere, it will tell the enemy then deacivate
    void OnTriggerEnter(Collider other)
    {

        if (other.name == "Nitro")
        {
            enemy.SendMessage("detected");

            Debug.Log("yay");

            gameObject.active = false;
        }

    }

        
}
