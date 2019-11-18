using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEnd : MonoBehaviour
{

    public CanvasGroup levelScreenGroup;

    public GameObject goal;

    public GameObject nitro;

    public GameObject movementScript;

    public GameObject camera;

    public GameObject boostScript;

    bool firstEnter = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter()
    {

        if(firstEnter == true)
        {
            levelScreenGroup.alpha = 1;
            levelScreenGroup.interactable = true;
            levelScreenGroup.blocksRaycasts = true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            firstEnter = false;

            camera.SendMessage("toggleMoveAllowed");

            movementScript.SendMessage("toggleMoveAllowed");

            boostScript.SendMessage("toggleMoveAllowed");

            Invoke("resetNitro", 3f);
        }

        
    }


    void resetNitro()
    {


        nitro.transform.position = new Vector3(goal.transform.position.x, goal.transform.position.y + 2, goal.transform.position.z);
        


    }


}
