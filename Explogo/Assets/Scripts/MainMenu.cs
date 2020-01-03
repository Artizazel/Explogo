using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{


    public Animator logoMove;

    public Button logo;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    public void playClicked()
    {

        SceneManager.LoadScene(1);

    }

    public void levelSelectClicked()
    {



    }

    public void quitClicked()
    {

        Application.Quit();

    }

    public void LogoClicked()
    {

        logoMove.SetTrigger("Logo Click");

        logo.interactable = false;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
