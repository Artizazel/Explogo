using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SateliteBlip : MonoBehaviour
{
    int wait = 0;

    public ParticleSystem blipParticle;


    private float blipActive = 0.0f;

    public float interval = 8f;

    

    //Will active the satelite particle breifly every 8 seconds
    void FixedUpdate()
    {

        if (Time.time > blipActive)
        {
            blipActive += interval;
            blipParticle.Play();

        }

    }
}
