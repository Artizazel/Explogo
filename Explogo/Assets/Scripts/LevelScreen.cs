using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelScreen : MonoBehaviour
{

     string sceneName;
     int nextSceneNum;

   

    //Finds information about the current and next scene
    void Start()
    {

        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        nextSceneNum = currentScene.buildIndex;
        nextSceneNum = nextSceneNum + 1;
        


    }



    //If the reset button is pressed the scene is reloaded
    public void resetLevel()
    {

        CollectibleCount.collectibles = 0;

        SceneManager.LoadScene(sceneName);
        
       

    }


    //If the next level button is pressed the next scene is loaded
    public void nextLevel()
    {
        CollectibleCount.collectibles = 0;
        SceneManager.LoadScene(nextSceneNum);
        

    }



    //If the main menu button is pressed the main menu scene is loaded
    public void mainMenu()
    {

        SceneManager.LoadScene(0);

    }



    
}
