using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEnd : MonoBehaviour
{

    public CanvasGroup levelScreenGroup;

    public GameObject timer;

    public GameObject goal;

    public GameObject nitro;

    public Rigidbody nitroRig;

    public GameObject movementScript;

    public GameObject camera;

    public GameObject boostScript;

    public GameObject enemy;

    public AudioSource blip;

    public Animator tntMessage;

    bool firstEnter = true;

    

   

    //When the player touches the end goal, this will freeze all movement and show the end screen
    void OnTriggerEnter(Collider other)
    {


        if(other.tag != "Enemy")
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

                    enemy.SendMessage("toggleMoveAllowed");

                    camera.SendMessage("toggleMoveAllowed");

                    movementScript.SendMessage("toggleMoveAllowed");

                    boostScript.SendMessage("toggleMoveAllowed");

                    timer.SendMessage("endScript");

                    

                    Invoke("resetNitro", 3f);
                }



            }
            else
            {


                tntMessage.SetBool("isEnd", true);




            }







        }

        

        
    }


    //Is called 3 seconds after the player ends the level, will put the player in the middle of the goal, just incase the player falls off while in the menu
    void resetNitro()
    {
        nitroRig.velocity = new Vector3(0, 0, 0);

        nitro.transform.position = new Vector3(goal.transform.position.x, goal.transform.position.y + 2, goal.transform.position.z);

        nitroRig.isKinematic = true;

    }


}
