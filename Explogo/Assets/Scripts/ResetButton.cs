using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetButton : MonoBehaviour
{

    bool resetAllowed = true;



    //Won't let the player reset the level using 'R' if they are in a menu
    void toggleReset()
    {

        if(resetAllowed == true)
        {
            resetAllowed = false;
        }
        else
        {
            resetAllowed = true;
        }


    }

    //Reloads the current level if R is pressed, and loads the menu scene if esc is press
    void Update()
    {

        if (resetAllowed == true)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {

                SceneManager.LoadScene(SceneManager.GetActiveScene().name);

                CollectibleCount.collectibles = 0;

            }
        }


        if(Input.GetKeyDown(KeyCode.Escape))
        {

            SceneManager.LoadScene(0);

        }

    }
}
