using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialScript : MonoBehaviour
{
    public Animator textHolder;

    public Image movementTut;
    public Image jumpTut;
    public Image boomTut;
    public Image comboTut;
    public Image bounceTut;
    public Image wdTut;
    public Image btnTut;
    public Image downTut;
    public Image tntTut;
    public Image allTut;

    public GameObject allObj;
    public GameObject tntObj;
    public GameObject downObj;
    public GameObject btnObj;
    public GameObject wdObj;
    public GameObject bounceObj;
    public GameObject comboObj;
    public GameObject boomObj;
    public GameObject jumpObj;

    bool btnHit = false;
    bool inDownTut = false;

    // Start is called before the first frame update
    void Start()
    {
        jumpTut.enabled = false;
        boomTut.enabled = false;
        comboTut.enabled = false;
        bounceTut.enabled = false;
        wdTut.enabled = false;
        btnTut.enabled = false;
        downTut.enabled = false;
        tntTut.enabled = false;
        allTut.enabled = false;


        textHolder.SetBool("tut", true);

        Invoke("fadeWASD", 12f);
    }


    void fadeWASD()
    {

        movementTut.CrossFadeAlpha(0, 0.5f, false);

        if(movementTut.enabled == true)
        {

            textHolder.SetBool("tut", false);

        }

    }


    public void jumpTutorial()
    {
        

        movementTut.enabled = false;

        textHolder.SetBool("tut", false);

        jumpTut.enabled = true;

        textHolder.SetBool("tut", true);

    }

    public void jumpEnd()
    {

        jumpTut.CrossFadeAlpha(0, 0.5f, false);

        textHolder.SetBool("tut", false);

        jumpObj.active = false;

    }


    public void boomTutorial()
    {

        jumpTut.enabled = false;

        boomTut.enabled = true;

        textHolder.SetBool("tut", true);

    }

    public void boomEnd()
    {

        boomTut.CrossFadeAlpha(0, 0.5f, false);

        textHolder.SetBool("tut", false);

        boomObj.active = false;

    }

    public void comboTutorial()
    {

        boomTut.enabled = false;

        comboTut.enabled = true;

        textHolder.SetBool("tut", true);

    }

    public void comboEnd()
    {

        comboTut.CrossFadeAlpha(0, 0.5f, false);

        textHolder.SetBool("tut", false);

        comboObj.active = false;

    }

    public void wdTutorial()
    {

        comboTut.enabled = false;

        wdTut.enabled = true;

        textHolder.SetBool("tut", true);

    }

    public void wdEnd()
    {

        //wdTut.CrossFadeAlpha(0, 0.5f, false);

        //textHolder.SetBool("tut", false);

        wdObj.active = false;

    }

    public void bounceTutorial()
    {

        wdTut.enabled = false;

        bounceTut.enabled = true;

        textHolder.SetBool("tut", true);

    }

    public void bounceEnd()
    {

        bounceTut.CrossFadeAlpha(0, 0.5f, false);

        textHolder.SetBool("tut", false);

        bounceObj.active = false;

    }

    public void btnTutorial()
    {

        bounceTut.enabled = false;

        btnTut.enabled = true;

        textHolder.SetBool("tut", true);

    }

    public void btnEnd()
    {

        btnTut.CrossFadeAlpha(0, 0.5f, false);

        //textHolder.SetBool("tut", false);

        btnObj.active = false;

    }

    public void buttonHit()
    {
        btnHit = true;
    }

    public void downTutorial()
    {
        if (btnHit == true)
        {

            Time.timeScale = 0.1f;

            btnTut.enabled = false;

            downTut.enabled = true;

            inDownTut = true;

            textHolder.SetBool("tut", true);
        }
    }

    public void downEnd()
    {

        if(inDownTut == true)
        {

            Time.timeScale = 2f;

            btnTut.CrossFadeAlpha(0, 0.5f, false);

            textHolder.SetBool("tut", false);

            downObj.active = false;

            inDownTut = false;

        }

        

    }

    public void tntTutorial()
    {


            downTut.enabled = false;

            tntTut.enabled = true;

            textHolder.SetBool("tut", true);
        
    }

    public void tntEnd()
    {

        


            //tntTut.CrossFadeAlpha(0, 0.5f, false);

            //textHolder.SetBool("tut", false);

            tntObj.active = false;
                      



    }

    public void allTutorial()
    {


        tntTut.enabled = false;

        allTut.enabled = true;

        textHolder.SetBool("tut", true);

    }

    public void allEnd()
    {




        allTut.CrossFadeAlpha(0, 0.5f, false);

        textHolder.SetBool("tut", false);

        allObj.active = false;




    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("left shift"))
        {
            downEnd();
        }


    //movementTut.enabled = true;
}
}
