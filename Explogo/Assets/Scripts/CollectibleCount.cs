using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectibleCount : MonoBehaviour
{


    static public int collectibles = 0;

    [SerializeField]
    public static Text counter;


    //Updates the counter on screen depending on the value of 'collectibles'


    void Start()
    {
        counter = GetComponent<Text>();
    }


    public static void counterUpdate()
    {

        counter.text = collectibles.ToString();

    
    }

    
}
