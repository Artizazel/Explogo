using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBonus : MonoBehaviour
{

    public Rigidbody player;

    private bool bounced;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnTriggerStay(Collider other)
    {

        bounced = false;

        if (Input.GetKey("space"))
        {

            if (bounced == false)
            {
                player.velocity = new Vector3(0, 10, 0);
                bounced = true;
            }

        }


    }




    // Update is called once per frame
    void Update()
    {
        
        
       




    }
}
