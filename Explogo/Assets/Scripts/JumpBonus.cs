using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBonus : MonoBehaviour
{

    public Rigidbody player;

    public AudioSource boom;

    public bool bounced;

    int boostNum = 1;

    public GameObject playerBody;

    public GameObject Explosion;

    public Transform Left;

    public Transform Right;

    public Transform Front;

    public Transform Back;

    public Transform Btm;

    private bool boosted;

    private float speed = 70000;


    bool moveAllowed = true;

    // Start is called before the first frame update
    void Start()
    {

        Time.timeScale = 2f;

    }


    private void hitWall()
    {



        bounced = false;


        


    }


    private void OnTriggerEnter(Collider other)
    {


        if (other.tag == "Floor")
        {
            bounced = false;

            boostNum = 1;
        }


    }

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


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("space"))
        {

            if (bounced == false)
            {
                player.velocity = new Vector3(player.velocity.x, 16, player.velocity.z);
                Instantiate(Explosion, Btm.position, transform.rotation);

                boom.Play();

                bounced = true;
            }



            
        }


        if (moveAllowed == true)
        {

            if (Input.GetMouseButtonDown(0))
            {

                if (boostNum > 0)
                {

                    boom.Play();

                    if (Input.GetKey(KeyCode.W))
                    {
                        player.velocity = new Vector3(0, player.velocity.y, 0);
                        player.AddForce(transform.forward * speed);
                        player.AddForce(transform.up * 10000);
                        Instantiate(Explosion, Back.position, transform.rotation);
                    }
                    else if (Input.GetKey(KeyCode.S))
                    {
                        player.velocity = new Vector3(0, player.velocity.y, 0);
                        player.AddForce(transform.forward * -50000f);
                        player.AddForce(transform.up * 10000);
                        Instantiate(Explosion, Front.position, transform.rotation);
                    }
                    else if (Input.GetKey(KeyCode.D))
                    {
                        player.velocity = new Vector3(0, player.velocity.y, 0);
                        player.AddForce(transform.right * 50000f);
                        player.AddForce(transform.up * 10000);
                        Instantiate(Explosion, Left.position, transform.rotation);
                    }
                    else if (Input.GetKey(KeyCode.A))
                    {
                        player.velocity = new Vector3(0, player.velocity.y, 0);
                        player.AddForce(transform.right * -50000f);
                        player.AddForce(transform.up * 10000);
                        Instantiate(Explosion, Right.position, transform.rotation);
                    }
                    else
                    {
                        player.velocity = new Vector3(0, player.velocity.y, 0);
                        player.AddForce(transform.forward * speed);
                        player.AddForce(transform.up * 10000);
                        Instantiate(Explosion, Back.position, transform.rotation);
                    }

                    boostNum--;

                }


            }



        }

    }
}
