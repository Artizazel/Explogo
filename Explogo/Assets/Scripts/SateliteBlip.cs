using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SateliteBlip : MonoBehaviour
{
    int wait = 0;

    public ParticleSystem blipParticle;


    private float blipActive = 0.0f;

    public float interval = 8f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Time.time > blipActive)
        {
            blipActive += interval;
            blipParticle.Play();

        }

    }
}
