using UnityEngine;
using System.Collections;

public class DrumPlay : MonoBehaviour
{

    AudioSource ac;
    void Start()
    {
        ac = GetComponent<AudioSource>();
    }
    void OnMouseDown()
    {
        ac.PlayOneShot(ac.clip);
    }
}