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

    bool firstEnter = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {


        if(other.tag != "Enemy")
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

                enemy.SendMessage("toggleMoveAllowed");

                camera.SendMessage("toggleMoveAllowed");

                movementScript.SendMessage("toggleMoveAllowed");

                boostScript.SendMessage("toggleMoveAllowed");

                timer.SendMessage("endScript");


                Invoke("resetNitro", 3f);
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
