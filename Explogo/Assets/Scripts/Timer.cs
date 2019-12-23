using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Text timer;

    private float time;

    public GameObject HUD;

    public GameObject highscore;

    public GameObject compHighscore;

    float minutes;

    float seconds;

    float fract;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void endScript()
    {

        string score = string.Format("{0:00}{1:00}{2:00}", minutes, seconds, fract);

        Debug.Log(score);

        HUD.SendMessage("checkHighscore" , float.Parse(score));

        compHighscore.SendMessage("checkHighscore", float.Parse(score));


        Destroy(this);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.deltaTime/2;


        minutes = time / 120;

        seconds = time % 60;

        fract = (time * 100) % 100;



        timer.text = string.Format ("{0:00} : {1:00} : {2:00}", minutes, seconds, fract);

    }
}
