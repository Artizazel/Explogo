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



    public FastFall()
    {

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {

        bounced = true;

        downBoostCooldown.color = Color.white;

        if (other.tag == "Floor")
        {
            player.velocity = new Vector3(0, 7, 0);
            
        }
        Invoke("resetBounce", 0.5f);

        falling = false;

    }


    // Update is called once per frame
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
