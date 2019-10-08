using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastFall : MonoBehaviour
{

    public Rigidbody player;

    private bool bounced;


    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {

        bounced = true;

        player.velocity = new Vector3(0, 5, 0);

        Invoke("resetBounce", 5f);

    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("left shift"))
        {

            if(bounced == false)
            {
                player.velocity = new Vector3(0, -20, 0);
            }

            
        }


        

    }


    private void resetBounce()
    {

        bounced = false;

    }



}
