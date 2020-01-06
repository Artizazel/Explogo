using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialEnd : MonoBehaviour
{

    public CanvasGroup levelScreenGroup;

    public GameObject goal;

    public GameObject nitro;

    public Rigidbody nitroRig;

    public GameObject movementScript;

    public GameObject camera;

    public GameObject boostScript;

    public AudioSource blip;

    public Animator tntMessage;

    bool firstEnter = true;


    // Start is called before the first frame update
    void Start()
    {
        
    }


    void OnTriggerEnter(Collider other)
    {


        if (other.tag != "Enemy")
        {



            if (CollectibleCount.collectibles > 0)
            {
                if (firstEnter == true)
                {

                    blip.Play();

                    firstEnter = false;
                    levelScreenGroup.alpha = 1;
                    levelScreenGroup.interactable = true;
                    levelScreenGroup.blocksRaycasts = true;
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;

                    nitro.SendMessage("toggleReset");

                    camera.SendMessage("toggleMoveAllowed");

                    movementScript.SendMessage("toggleMoveAllowed");

                    boostScript.SendMessage("toggleMoveAllowed");




                    Invoke("resetNitro", 3f);
                }



            }
            else
            {


                tntMessage.SetBool("isEnd", true);




            }







        }




    }


    void resetNitro()
    {
        nitroRig.velocity = new Vector3(0, 0, 0);

        nitro.transform.position = new Vector3(goal.transform.position.x, goal.transform.position.y + 2, goal.transform.position.z);

        nitroRig.isKinematic = true;

    }

}
