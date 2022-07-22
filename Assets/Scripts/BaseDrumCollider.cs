using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseDrumCollider : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource ac;
    void Start()
    {
        ac = GetComponent<AudioSource>(); 
    }
    
    void OnCollisionEnter(Collision collision)
    {
        ac.PlayOneShot(ac.clip);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
