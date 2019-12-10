using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscores : MonoBehaviour
{

    float time;


    float newhighscore;

    float[] highscores = new float[3];

    string[] highscoreNames = new string[3];
    
    int highscorePos;

    public InputField input;

    public CanvasGroup endScreen;

    public CanvasGroup highscoreScreen;


    public Text first;

    public Text second;

    public Text third;

    public AudioSource victory;

    Text[] scoreboard = new Text[3];




    // Start is called before the first frame update
    void Start()
    {

        scoreboard[2] = first;
        scoreboard[1] = second;
        scoreboard[0] = third;

        //resetScores();

        getHighscores();


        for (int i = 0; i < highscores.Length; i++)
        {


            //Debug.Log(PlayerPrefs.GetFloat(i.ToString()) + "  highscore");


        }

        /*
        highscores[0] = highscore0;

        highscores[1] = highscore1;

        highscores[2] = highscore2;
        */

    }

    void checkHighscore(float newHighscore)
    {
        highscorePos = -1;



        for (int i = 0; i < highscores.Length; i++)
        {
            if(newHighscore < highscores[i])
            {
                highscorePos = i;
            }
        }
        

        if(highscorePos > -1)
        {

            endScreen.alpha = 0;
            endScreen.blocksRaycasts = false;
            endScreen.interactable = false;


            highscoreScreen.alpha = 1;
            highscoreScreen.blocksRaycasts = true;
            highscoreScreen.interactable = true;

            victory.Play();

            setHighscore(highscorePos, newHighscore);


            
        }



    }


    public void highscoreName()
    {

        highscoreNames[highscorePos] = input.text;

        //Debug.Log(highscoreNames[highscorePos]);


        for (int i = 0; i < highscoreNames.Length; i++)
        {
            //Debug.Log(highscoreNames[i]);

            PlayerPrefs.SetString("h" + i.ToString(), highscoreNames[i]);

        }

        highscoreScreen.alpha = 0;
        highscoreScreen.blocksRaycasts = false;
        highscoreScreen.interactable = false;

        endScreen.alpha = 1;
        endScreen.blocksRaycasts = true;
        endScreen.interactable = true;



        getHighscores();

    }



    void setHighscore(int position, float highscore)
    {

        Debug.Log(position);

        float tempHi1 = highscores[position];

        float temphi2;

        string tempname1 = highscoreNames[position];

        string tempname2;

        for (int i = position-1; i >= 0; i--)
        {

            Debug.Log(highscores[i]);


            
            tempname2 = highscoreNames[i];

            highscoreNames[i] = tempname1;

            tempname1 = tempname2;
            

            temphi2 = highscores[i];

            highscores[i] = tempHi1;

            tempHi1 = temphi2;

        }


        highscores[position] = highscore;

        for (int i = 0; i < highscores.Length; i++)
        {

            PlayerPrefs.SetFloat(i.ToString(), highscores[i]);


           
        }

        newhighscore = highscore;

        highscorePos = position;


    }


    void getHighscores()
    {




        for (int i = 0; i < highscores.Length; i++)
        {

            highscores[i] = PlayerPrefs.GetFloat(i.ToString());

            highscoreNames[i] = PlayerPrefs.GetString("h" + i.ToString());

            Debug.Log(highscoreNames[i]);

            string hiScore = highscores[i].ToString();

            hiScore = hiScore.Insert(hiScore.Length - 2, ":");

            if (hiScore.Length > 5)
            hiScore = hiScore.Insert(hiScore.Length - 5, ":");


            scoreboard[i].text = highscoreNames[i] + " - " + hiScore;


        }

        PlayerPrefs.Save();

    }


    void resetScores()
    {



        for (int i = 0; i < highscores.Length; i++)
        {

            PlayerPrefs.SetString("h" + i.ToString(), "Randy");

            PlayerPrefs.SetFloat(i.ToString(), 999999);


        }


    }



    // Update is called once per frame
    void Update()
    {
        






    }
}
