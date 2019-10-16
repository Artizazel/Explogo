using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionLeft : MonoBehaviour
{



    public Rigidbody player;

    public GameObject Explosion;

    public Transform Left;




    private void OnTriggerStay(Collider other)
    {

        player.AddForce(transform.right * 50000f);
        Instantiate(Explosion, Left.position, transform.rotation);


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
