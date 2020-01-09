using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CompleteHighscores : MonoBehaviour
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




    //Stores and displays an array of highscores in which the player collected all of the TNT







    //fills the highscores array with fake scores (in case no scores are set yet) then retrives the scores set by previous plays
    void Start()
    {

        scoreboard[2] = first;
        scoreboard[1] = second;
        scoreboard[0] = third;



        fillArray();

       
        

        getHighscores();


        

        

    }



    //Checks if the player collected all of the TNT in the level, then checks if the time they finished with was less that any of the top 3
    void checkHighscore(float newHighscore)
    {



        

        if (CollectibleCount.collectibles == 3)
        {

            Debug.Log("Script Called hc");

            highscorePos = -1;



            for (int i = 0; i < highscores.Length; i++)
            {
                if (newHighscore < highscores[i])
                {
                    highscorePos = i;
                }
            }


            if (highscorePos > -1)
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

    }



    //Takes the input from the text box and stores it in a separate array at the same index as the highscore
    public void highscoreName()
    {

        highscoreNames[highscorePos] = input.text;

        


        for (int i = 0; i < highscoreNames.Length; i++)
        {
            

            PlayerPrefs.SetString(SceneManager.GetActiveScene().name + "hc" + i.ToString(), highscoreNames[i]);

        }

        highscoreScreen.alpha = 0;
        highscoreScreen.blocksRaycasts = false;
        highscoreScreen.interactable = false;

        endScreen.alpha = 1;
        endScreen.blocksRaycasts = true;
        endScreen.interactable = true;



        getHighscores();

    }




    //Rearranges the array to fit the new score in (push and pop)
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

            PlayerPrefs.SetFloat(SceneManager.GetActiveScene().name + "c" + i.ToString(), highscores[i]);


           
        }

        newhighscore = highscore;

        highscorePos = position;


    }




    //Retrives the scores from playerpreferences and puts them in the realtime array, then adds the scores to the ingame leaderboard
    void getHighscores()
    {




        for (int i = 0; i < highscores.Length; i++)
        {

            highscores[i] = PlayerPrefs.GetFloat(SceneManager.GetActiveScene().name + "c" + i.ToString());

            highscoreNames[i] = PlayerPrefs.GetString(SceneManager.GetActiveScene().name + "hc" + i.ToString());

            Debug.Log(highscoreNames[i]);

            Debug.Log(highscores[i]);

            string hiScore = highscores[i].ToString();

            hiScore = hiScore.Insert(hiScore.Length - 2, ":");

            if (hiScore.Length > 5)
            hiScore = hiScore.Insert(hiScore.Length - 5, ":");


            scoreboard[i].text = highscoreNames[i] + " - " + hiScore;


        }

        PlayerPrefs.Save();

    }



    //Overrides all of the variables in the player preferences with maximum time scores
    void resetScores()
    {


        
        for (int i = 0; i < highscores.Length; i++)
        {

            PlayerPrefs.SetString(SceneManager.GetActiveScene().name + "hc" + i.ToString(), "Randy");

            PlayerPrefs.SetFloat(SceneManager.GetActiveScene().name + "c" + i.ToString(), 999999);


        }
        

    }

    //Overrides all of the variables in the arrays with maximum time scores
    void fillArray()
    {



        for (int i = 0; i < highscores.Length; i++)
        {

            highscoreNames[i] = "Randy"; 


            highscores[i] = 999999;



        }


    }



    //Is used to reset scores when ingame
    void Update()
    {



        if (Input.GetKey(KeyCode.Equals) && (Input.GetKey(KeyCode.Z)))
        {
            resetScores();
        }

        if (Input.GetKey(KeyCode.Equals) && (Input.GetKey(KeyCode.X)))
        {
            PlayerPrefs.DeleteAll();
        }


    }
}
