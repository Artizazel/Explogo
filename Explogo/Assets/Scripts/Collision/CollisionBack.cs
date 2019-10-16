using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBack : MonoBehaviour
{



    public Rigidbody player;

    public GameObject Explosion;

    public Transform Back;




    private void OnTriggerStay(Collider other)
    {

        player.AddForce(transform.forward * 50000f);
        Instantiate(Explosion, Back.position, transform.rotation);


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
