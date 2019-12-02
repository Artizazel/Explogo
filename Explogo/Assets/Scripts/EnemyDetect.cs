using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetect : MonoBehaviour
{

    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    void OnTriggerEnter(Collider other)
    {

        if (other.name == "Nitro")
        {
            enemy.SendMessage("detected");

            Debug.Log("yay");

            gameObject.active = false;
        }

    }

            // Update is called once per frame
            void Update()
    {
        
    }
}
