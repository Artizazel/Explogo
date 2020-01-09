using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullMovement : MonoBehaviour
{

    private float speed = 15f;

    bool moveAllowed = true;

    
    void Start()
    {

        Cursor.lockState = CursorLockMode.Locked;

    }


    //Is called at the end of the level, stops the player from moving
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



    void destroyScript()
    {

        Destroy(this);

    }


    //Moves the player in the direction they press depending on their current orientation, will also unlock the cursor when they press escape
    void Update()
    {

        if (moveAllowed == true)
        {


            float translation = Input.GetAxis("Vertical") * speed;
            float strafe = Input.GetAxis("Horizontal") * speed;

            translation *= Time.deltaTime;
            strafe *= Time.deltaTime;

            transform.Translate(strafe, 0, translation);

            if (Input.GetKeyDown("escape"))
            {
                Cursor.lockState = CursorLockMode.None;
            }

        }
    }
}
