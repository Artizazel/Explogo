using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectTNT : MonoBehaviour
{

    public GameObject explosion;

    public AudioSource boom;


    
    //Is called when the player collects the TNT, plays an explosion sound, emits an explosion, and adds 1 to the collectible count in the 'CollectibleCount' script
    void OnTriggerEnter(Collider other)
    {

        Debug.Log("touched");

        boom.Play();

        Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);

        CollectibleCount.collectibles++;

        

        Debug.Log(CollectibleCount.collectibles);


        CollectibleCount.counterUpdate();

        Destroy(gameObject);

    }

    
}
