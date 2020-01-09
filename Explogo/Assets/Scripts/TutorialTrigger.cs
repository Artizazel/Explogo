using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialTrigger : MonoBehaviour
{

    public GameObject tutorialScript;

    public Rigidbody nitro;

    

    //Detects when the player has entered a tutorial zone and will tell TutorialScript which zone they have entered


    void OnTriggerExit(Collider other)
    {

        if (other.transform.name == "Jump Tut")
        {
            tutorialScript.SendMessage("jumpEnd");
        }
        else if (other.transform.name == "Boom Tut")
        {
            tutorialScript.SendMessage("boomEnd");
        }
        else if (other.transform.name == "Combo Tut")
        {
            tutorialScript.SendMessage("comboEnd");
        }
        else if (other.transform.name == "Bounce Tut")
        {
            tutorialScript.SendMessage("bounceEnd");
        }
        else if (other.transform.name == "Well Done Tut")
        {
            tutorialScript.SendMessage("wdEnd");
        }
        else if (other.transform.name == "Button Tut")
        {
            tutorialScript.SendMessage("btnEnd");
        }
        else if (other.transform.name == "Down Tut")
        {
            tutorialScript.SendMessage("downEnd");
        }
        else if (other.transform.name == "TNT Tut")
        {
            tutorialScript.SendMessage("tntEnd");
        }
        else if (other.transform.name == "All Tut")
        {
            tutorialScript.SendMessage("allEnd");
        }

    }


    void OnTriggerEnter(Collider other)
    {

        if (other.transform.name == "Button")
        {
            tutorialScript.SendMessage("buttonHit");
            nitro.velocity = new Vector3(nitro.velocity.x, 10, nitro.velocity.z);
        }


        if (other.transform.name == "Jump Tut")
        {
            tutorialScript.SendMessage("jumpTutorial");
        }
        else if (other.transform.name == "Boom Tut")
        {
            tutorialScript.SendMessage("boomTutorial");
        }
        else if (other.transform.name == "Combo Tut")
        {
            tutorialScript.SendMessage("comboTutorial");
        }
        else if (other.transform.name == "Bounce Tut")
        {
            tutorialScript.SendMessage("bounceTutorial");
        }
        else if (other.transform.name == "Well Done Tut")
        {
            tutorialScript.SendMessage("wdTutorial");
        }
        else if (other.transform.name == "Button Tut")
        {
            tutorialScript.SendMessage("btnTutorial");
        }
        else if (other.transform.name == "Down Tut")
        {
            tutorialScript.SendMessage("downTutorial");
        }
        else if (other.transform.name == "TNT Tut")
        {
            tutorialScript.SendMessage("tntTutorial");
        }
        else if (other.transform.name == "All Tut")
        {
            tutorialScript.SendMessage("allTutorial");
        }

    }



}
