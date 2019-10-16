using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBonus : MonoBehaviour
{

    public Rigidbody player;

    public bool bounced;

    public GameObject playerBody;

    public GameObject Explosion;

    public Transform Left;

    public Transform Right;

    public Transform Front;

    public Transform Back;

    public Transform Btm;

    private bool boosted;

    private float speed = 70000;

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
                player.velocity = new Vector3(0, 13, 0);
                Instantiate(Explosion, Btm.position, transform.rotation);
            }

        }


        bounced = true;


    }


    private void OnTriggerEnter(Collider other)
    {

        bounced = true;



    }




    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {

            if (bounced == true)
            {

                if (Input.GetKey(KeyCode.W))
                {
                    player.AddForce(transform.forward * speed);
                    Instantiate(Explosion, Back.position, transform.rotation);
                }
                else if (Input.GetKey(KeyCode.S))
                {
                    player.AddForce(transform.forward * -50000f);
                    Instantiate(Explosion, Front.position, transform.rotation);
                }
                else if (Input.GetKey(KeyCode.D))
                {
                    player.AddForce(transform.right * 50000f);
                    Instantiate(Explosion, Left.position, transform.rotation);
                }
                else if (Input.GetKey(KeyCode.A))
                {
                    player.AddForce(transform.right * -50000f);
                    Instantiate(Explosion, Right.position, transform.rotation);
                }
                else
                {
                    player.AddForce(transform.forward * speed);
                    Instantiate(Explosion, Back.position, transform.rotation);
                }

                bounced = false;

            }


        }





    }
}
