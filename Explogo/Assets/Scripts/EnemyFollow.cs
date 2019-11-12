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


    // Start is called before the first frame update
    void Start()
    {
        playerObj = GameObject.Find("Nitro");

        playerTrans = playerObj.transform;

        enemyTrans = GetComponent<Transform>();

        enemyRig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {



        enemyTrans.LookAt(playerTrans);


        
        
        enemyRig.AddForce(enemyTrans.forward * 20);



        velocityTimer++;
        
        if(velocityTimer == 200)
        {
            velocityReset();
        }



    }

    void velocityReset()
    {
        enemyRig.velocity = new Vector3(0, 0, 0);

        velocityTimer = 0;
    }


}
