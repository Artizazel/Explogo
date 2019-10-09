using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("destroyEffect", 3f);
    }



    void destroyEffect()
    {
        Destroy(gameObject);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
