using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{

    public AudioSource blip;

    public GameObject evilExplosion;

    public Transform enemyTrans;

    
    void Start()
    {
        enemyTrans = GetComponent<Transform>();
    }

   



    //When the enemy touches any surface it emits an electrical explosion prefab and plays a beep noise
    private void OnCollisionEnter()
    {


        Instantiate(evilExplosion, enemyTrans);
        blip.Play();

    }


}
