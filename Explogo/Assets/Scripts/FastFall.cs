using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FastFall : MonoBehaviour
{

    public Rigidbody player;

    public AudioSource boom;

    private bool bounced;

    public Transform top;

    public GameObject Explosion;

    private bool falling;

    public Image downBoostCooldown;

    public GameObject sparks;

    public FastFall()
    {

    }


    

    //Will reset the cooldown of 'FastFall' either when the player touches the floor, also has a 5 second internal cooldown
    private void OnTriggerEnter(Collider other)
    {

        bounced = true;

        downBoostCooldown.color = Color.white;

        if (other.tag == "Floor")
        {
            player.velocity = new Vector3(0, 7, 0);

            Instantiate(sparks, transform.position, transform.rotation);
            
        }
        Invoke("resetBounce", 0.5f);

        falling = false;

    }




    //Activates 'FastFall' when the player presses shift
    void Update()
    {

        if (Input.GetKeyDown("left shift"))
        {

            if(bounced == false)
            {
                player.velocity = new Vector3(0, -30, 0);

                downBoostCooldown.color = Color.clear;

                if (falling == false)
                {
                    boom.Play();
                    Instantiate(Explosion, top.position, top.rotation);
                    falling = true;
                }
            }

            
        }



    }


    //Used to allow the player to FastFall again after 5 seconds
    private void resetBounce()
    {

        bounced = false;

    }



}
