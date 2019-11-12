using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{


    public GameObject evilExplosion;

    public Transform enemyTrans;

    // Start is called before the first frame update
    void Start()
    {
        enemyTrans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        



    }

    private void OnCollisionEnter()
    {


        Instantiate(evilExplosion, enemyTrans);

    }


}
