using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectTNT : MonoBehaviour
{

    public GameObject explosion;

    public AudioSource boom;


    // Start is called before the first frame update
    void Start()
    {

    }

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

    // Update is called once per frame
    void Update()
    {
    }
}
