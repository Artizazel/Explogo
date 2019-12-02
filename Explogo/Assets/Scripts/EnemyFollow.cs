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

    // Start is called before the first frame update
    void Start()
    {
        playerObj = GameObject.Find("Nitro");

        playerTrans = playerObj.transform;

        enemyTrans = GetComponent<Transform>();

        enemyRig = GetComponent<Rigidbody>();
    }


    void detected()
    {

            playerDetected = true;

    }


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



    // Update is called once per frame
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
