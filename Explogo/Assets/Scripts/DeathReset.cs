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


    

    //When the player touches the deathbox at the bottom of the level, it disables all movement for a few seconds then resets the level
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


    //Finds the current scene and reloads it
    void resetNitro()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);


    }




}
