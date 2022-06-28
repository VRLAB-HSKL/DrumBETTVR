using HTC.UnityPlugin.Vive;
using UnityEngine;
public class DetectCollisions : MonoBehaviour
{
    
    // Start is called before the first frame update
    AudioSource ac;
    void Start()
    {
        ac = GetComponent<AudioSource>(); 
    }
    
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision: " + collision.collider.tag);
        ac.PlayOneShot(ac.clip);
        ViveInput.TriggerHapticVibrationEx(
            collision.collider.CompareTag("Right") ? HandRole.RightHand : HandRole.LeftHand, amplitude: 0.45f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
