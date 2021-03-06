﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionRight : MonoBehaviour
{

    public Rigidbody player;

    public GameObject Explosion;

    public Transform Right;

    bool moveAllowed = true;

    public AudioSource boom;


    void toggleMoveAllowed()
    {

        if (moveAllowed == true)
        {
            moveAllowed = false;
        }
        else
        {
            moveAllowed = true;
        }

    }


    void destroyScript()
    {

        Destroy(this);

    }

    private void OnTriggerStay(Collider other)
    {

        if (moveAllowed == true)
        {

            boom.Play();
            player.AddForce(transform.right * -30000f);
        Instantiate(Explosion, Right.position, transform.rotation);
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
