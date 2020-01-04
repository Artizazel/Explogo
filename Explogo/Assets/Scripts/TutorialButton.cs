using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialButton : MonoBehaviour
{
    public Animator whiteWalls;

    public GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame

        void OnTriggerEnter()
    {

        whiteWalls.SetTrigger("Button Hit");


        Destroy(button);
        Destroy(gameObject);

    }

    void Update()
    {
        
    }
}
