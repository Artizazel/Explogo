using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBounce : MonoBehaviour
{

    public GameObject bounceScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {


        bounceScript.SendMessage("hitWall");


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
