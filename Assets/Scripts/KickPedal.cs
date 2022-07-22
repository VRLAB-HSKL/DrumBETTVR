using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickPedal : MonoBehaviour
{
    private Animator anim;
    private GameObject footTracker;
    AudioSource ac;
    
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        footTracker = GameObject.FindWithTag("Tracker");
    }

    // Update is called once per frame
    void Update()
    {
        // Ca. die Hoehe des Trackers, wenn Animation gestartet wird: (Kick Pedal weg von Bass Drum): 1.2
        // Ca. die Hoehe, wenn Kick Pedal an der Bass Drum anliegt: 0.9
        // Debug.Log((-footTracker.transform.position.y + 1.3) * 3);
        anim.Play("Scene", 0, (float)(-footTracker.transform.position.y + 1.3) * 3);
    }
}
