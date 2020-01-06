using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{


    public Animator logoMove;

    public Animator buttonMove;

    public Animator levelScreen;
   // public Animator buttonMove2;
    //public Animator buttonMove3;

    public Button logo;


    // Start is called before the first frame update
    void Start()
    {

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }

    public void tutorial()
    {

        SceneManager.LoadScene(1);

    }

    public void level1()
    {

        SceneManager.LoadScene(2);

    }

    public void level2()
    {

        SceneManager.LoadScene(3);

    }

    public void playClicked()
    {

        SceneManager.LoadScene(1);

    }

    public void backClicked()
    {

        levelScreen.SetTrigger("Back Clicked");

    }

    public void levelSelectClicked()
    {

        levelScreen.SetTrigger("Level Screen Click");


    }

    public void quitClicked()
    {

        Application.Quit();

    }

    public void LogoClicked()
    {

        
        logoMove.SetTrigger("Logo Click");

        buttonMove.SetTrigger("Logo Click");
        //buttonMove2.SetTrigger("Logo Click");
       // buttonMove3.SetTrigger("Logo Click");

        logo.interactable = false;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
