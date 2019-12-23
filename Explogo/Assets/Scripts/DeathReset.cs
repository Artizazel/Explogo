using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DeathReset : MonoBehaviour
{

    public GameObject camera;

    public Rigidbody cameraRig;

    public GameObject pogoPole;

    public GameObject movementScript;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    void OnTriggerEnter(Collider obj)
    {

        if (obj.name == "Nitro")
        {
            Debug.Log(obj.name);

            

            camera.transform.parent = gameObject.transform;

            movementScript.BroadcastMessage("destroyScript");

            camera.SendMessage("destroyScript");

            movementScript.SendMessage("destroyScript");


            cameraRig.isKinematic = false;

            pogoPole.active = false;

            CollectibleCount.collectibles = 0;

            Invoke("resetNitro", 3);

        }
        

    }


    void resetNitro()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);


    }




}
