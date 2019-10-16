using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionRight : MonoBehaviour
{

    public Rigidbody player;

    public GameObject Explosion;

    public Transform Right;




    private void OnTriggerStay(Collider other)
    {

        player.AddForce(transform.right * -50000f);
        Instantiate(Explosion, Right.position, transform.rotation);


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
