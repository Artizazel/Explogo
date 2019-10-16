using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionFront : MonoBehaviour
{

    public Rigidbody player;

    public GameObject Explosion;

    public Transform Front;

    


    private void OnTriggerStay(Collider other)
    {

        player.AddForce(transform.forward * -50000f);
        Instantiate(Explosion, Front.position, transform.rotation);



    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
