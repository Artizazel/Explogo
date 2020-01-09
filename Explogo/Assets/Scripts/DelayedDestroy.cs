using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedDestroy : MonoBehaviour
{
    



    //Destorys the game object after 3 seconds


    
    void Start()
    {
        Invoke("destroyEffect", 3f);
    }



    void destroyEffect()
    {
        Destroy(gameObject);
    }


    
}
