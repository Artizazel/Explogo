using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullMovement : MonoBehaviour
{

    private float speed = 15f;

    bool moveAllowed = true;

    // Start is called before the first frame update
    void Start()
    {

        Cursor.lockState = CursorLockMode.Locked;



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


    void destroyScript()
    {

        Destroy(this);

    }

    // Update is called once per frame
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
