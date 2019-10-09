using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionBoost : MonoBehaviour
{

    public Rigidbody player;

    public GameObject Explosion;

    public Transform Left;

    public Transform Right;

    public Transform Front;

    public Transform Back;

    private bool boosted;

    private float speed = 70000;

    public GameObject pogoPole;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {




        if (Input.GetMouseButtonDown(0))
        {

            if (boosted == false)
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
                    Instantiate(Explosion, Left.position, transform.rotation);
                }
                else
                {
                    player.AddForce(transform.forward * speed);
                    Instantiate(Explosion, Back.position, transform.rotation);
                }

            }


        }
    }

    void boostStart()
    {

        StartCoroutine("boostCancel");

        

    }

    IEnumerator boostCancel()
    {

        yield return new WaitForSeconds(2f);

        boosted = true;

        Invoke("boostReset", 4f);


    }

    void boostReset()
    {

        boosted = false;

    }



}
