using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionFront : MonoBehaviour
{

    public Rigidbody player;

    public GameObject Explosion;

    public Transform Front;

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

            player.AddForce(transform.forward * -60000f);
        Instantiate(Explosion, Front.position, transform.rotation);

        }

    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
