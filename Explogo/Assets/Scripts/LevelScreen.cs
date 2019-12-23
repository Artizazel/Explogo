using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelScreen : MonoBehaviour
{

     string sceneName;
     int nextSceneNum;

    // Start is called before the first frame update
    void Start()
    {

        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        nextSceneNum = currentScene.buildIndex;
        nextSceneNum = nextSceneNum + 1;
        


    }


    public void resetLevel()
    {

        CollectibleCount.collectibles = 0;

        SceneManager.LoadScene(sceneName);
        
       

    }

    public void nextLevel()
    {
        CollectibleCount.collectibles = 0;
        SceneManager.LoadScene(nextSceneNum);
        

    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
