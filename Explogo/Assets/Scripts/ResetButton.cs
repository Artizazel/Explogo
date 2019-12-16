using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetButton : MonoBehaviour
{

    bool resetAllowed = true;



    // Start is called before the first frame update
    void Start()
    {
        



    }

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

    // Update is called once per frame
    void Update()
    {

        if (resetAllowed == true)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {

                SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            }
        }

    }
}
