using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialButton : MonoBehaviour
{
    public Animator whiteWalls;

    public GameObject button;

    


 
    //Moves the walls down using an animator when the player touches a button, and destroys the button
        void OnTriggerEnter()
    {

        whiteWalls.SetTrigger("Button Hit");


        Destroy(button);
        Destroy(gameObject);

    }

    
}
