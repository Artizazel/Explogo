using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectibleCount : MonoBehaviour
{


    static public int collectibles = 0;

    [SerializeField]
    public static Text counter;

    // Start is called before the first frame update
    void Start()
    {
        counter = GetComponent<Text>();
    }


    public static void counterUpdate()
    {

        counter.text = collectibles.ToString();

    
    }

    // Update is called once per frame
    void Update()
    {

    }
}
