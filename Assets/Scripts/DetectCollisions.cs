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
        if (collision.collider.GetComponent<PositionTracker>().positionDelta.y < 0) return;
        // Debug.Log("Collision: " + collision.collider.tag);
            
        ac.PlayOneShot(ac.clip);
       
        if (collision.collider.CompareTag("Right"))
        {
            ViveInput.TriggerHapticVibrationEx(HandRole.RightHand, amplitude: 0.45f);
        }
        else if (collision.collider.CompareTag("Left"))
        {
            ViveInput.TriggerHapticVibrationEx(HandRole.LeftHand, amplitude: 0.45f);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
