using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessToggle : MonoBehaviour
{

    PostProcessVolume volume;

    // Start is called before the first frame update
    void Start()
    {
        volume = gameObject.GetComponent<PostProcessVolume>();
        

        if(PlayerPrefs.GetInt("postProcessing") == 0)
        {
            volume.enabled = false;
        }
        else if (PlayerPrefs.GetInt("postProcessing") == 1)
        {
            volume.enabled = true;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
