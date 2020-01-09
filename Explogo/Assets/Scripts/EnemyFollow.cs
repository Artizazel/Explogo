using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{

    public GameObject playerObj;

    public Transform playerTrans;

    public Transform enemyTrans;

    public Rigidbody enemyRig;

    public int velocityTimer = 0;

    bool playerDetected = false;

    public Collider detectionSphere;

    bool moveAllowed = true;




    //Sets all of the relevant variables
    void Start()
    {
        playerObj = GameObject.Find("Nitro");

        playerTrans = playerObj.transform;

        enemyTrans = GetComponent<Transform>();

        enemyRig = GetComponent<Rigidbody>();
    }



    //Used by the EnemyDetect script to tell this script that the enemy can now follow the player
    void detected()
    {

            playerDetected = true;

    }


    //Stops the enemy from moving when the player has completed the level
    void toggleMoveAllowed()
    {

        if (moveAllowed == true)
        {
            moveAllowed = false;

            enemyRig.velocity = new Vector3(0, 0, 0);
        }
        else
        {
            moveAllowed = true;
        }



    }



    //Constantly aims at the player and follows them when detected, will regularly stop all momentum in order to chase more effectively and seem more robotic
    void FixedUpdate()
    {


        if (playerDetected == true)
        {
            if (moveAllowed == true)
            {

                enemyTrans.LookAt(playerTrans);




                enemyRig.AddForce(enemyTrans.forward * 20000);



                velocityTimer++;

                if (velocityTimer == 200)
                {
                    velocityReset();
                }
            }

        }



    }

    void velocityReset()
    {
        enemyRig.velocity = new Vector3(0, 0, 0);

        velocityTimer = 0;
    }


}
