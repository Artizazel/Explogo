using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastFall : MonoBehaviour
{

    public Rigidbody player;

    private bool bounced;

    public Transform top;

    public GameObject Explosion;

    private bool falling;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {

        bounced = true;

        player.velocity = new Vector3(0, 5, 0);

        Invoke("resetBounce", 5f);

        falling = false;

    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("left shift"))
        {

            if(bounced == false)
            {
                player.velocity = new Vector3(0, -20, 0);

                if (falling == false)
                {
                    Instantiate(Explosion, top.position, transform.rotation);
                    falling = true;
                }
            }

            
        }


        

    }


    private void resetBounce()
    {

        bounced = false;

    }



}
