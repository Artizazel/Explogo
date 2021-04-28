using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public Image jumpBoost;

    public Image boomBoost;

    public Image stopBoost;

    bool stopBoostCooledDown = true;

    bool moveAllowed = true;






    //Sets the game to be twice as fast
    void Start()
    {

        Time.timeScale = 2f;

        jumpBoost = GameObject.Find("Jump Boost Cooldown").GetComponent<Image>();
        boomBoost = GameObject.Find("Boom Boost Cooldown").GetComponent<Image>();
        stopBoost = GameObject.Find("Stop Boost Cooldown").GetComponent<Image>();

    }



    //Used by other scripts to reset the 'JumpBoost' cooldown upon hitting a wall instead of a floor
    private void hitWall()
    {



        bounced = false;

        jumpBoost.color = Color.white;



    }



    //Resets the cooldown of 'BoomBoost' and 'JumpBoost' when the player hits the ground or 'Boom Fuel'
    private void OnTriggerEnter(Collider other)
    {


        if (other.tag == "Boom Fuel" || other.tag == "Floor")
        {
            bounced = false;

            boomBoost.color = Color.white;

            stopBoost.color = Color.white;

            stopBoostCooledDown = true;

            boostNum = 1;

        }


    }



    //Stops the player from being able to use abilities when in menus
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


    //Will activate 'JumpBoost' if the player presses space and it's not on cooldown
    //Will Will activate 'BoomBoost' if the player presses the left mouse button and it's not on cooldown
    void Update()
    {

        if (Input.GetKey("space"))
        {

            if (bounced == false)
            {

                jumpBoost.color = Color.clear;

                player.velocity = new Vector3(player.velocity.x, 20, player.velocity.z);
                Instantiate(Explosion, Btm.position, transform.rotation);

                boom.Play();

                bounced = true;
            }



            
        }


        if (moveAllowed == true)
        {


            if(Input.GetMouseButtonDown(1))
            {

                if(stopBoostCooledDown == true)
                {
                    boom.Play();

                    player.velocity = new Vector3(0, 0, 0);

                    Instantiate(Explosion, transform.position, transform.rotation);

                    stopBoost.color = Color.clear;

                    stopBoostCooledDown = false;
                }


            }

            if (Input.GetMouseButtonDown(0))
            {

                if (boostNum > 0)
                {

                    boom.Play();

                    if (Input.GetKey(KeyCode.W))
                    {
                        player.velocity = new Vector3(0, player.velocity.y, 0);
                        player.AddForce(transform.forward * speed);
                        Instantiate(Explosion, Back.position, transform.rotation);
                    }
                    else if (Input.GetKey(KeyCode.S))
                    {
                        player.velocity = new Vector3(0, player.velocity.y, 0);
                        player.AddForce(transform.forward * -50000f);
                        Instantiate(Explosion, Front.position, transform.rotation);
                    }
                    else if (Input.GetKey(KeyCode.D))
                    {
                        player.velocity = new Vector3(0, player.velocity.y, 0);
                        player.AddForce(transform.right * 50000f);
                        Instantiate(Explosion, Left.position, transform.rotation);
                    }
                    else if (Input.GetKey(KeyCode.A))
                    {
                        player.velocity = new Vector3(0, player.velocity.y, 0);
                        player.AddForce(transform.right * -50000f);
                        Instantiate(Explosion, Right.position, transform.rotation);
                    }
                    else
                    {
                        player.velocity = new Vector3(0, player.velocity.y, 0);
                        player.AddForce(transform.forward * speed);
                        Instantiate(Explosion, Back.position, transform.rotation);
                    }

                    player.AddForce(transform.up * 25000);

                    boomBoost.color = Color.clear;
                    boostNum--;

                }


            }



        }

    }
}
