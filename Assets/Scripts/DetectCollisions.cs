<<<<<<< HEAD
using HTC.UnityPlugin.Vive;
using UnityEngine;
=======
using UnityEngine;

>>>>>>> 7cab9024b46e89396d396950c19eea2f33ae1718
public class DetectCollisions : MonoBehaviour
{
    
    // Start is called before the first frame update
<<<<<<< HEAD
    AudioSource ac;
    void Start()
    {
        ac = GetComponent<AudioSource>(); 
=======
    void Start()
    {
        
>>>>>>> 7cab9024b46e89396d396950c19eea2f33ae1718
    }
    
    void OnCollisionEnter(Collision collision)
    {
<<<<<<< HEAD
        Debug.Log("Collision: " + collision.collider.tag);
        ac.PlayOneShot(ac.clip);
        ViveInput.TriggerHapticVibrationEx(
            collision.collider.CompareTag("Right") ? HandRole.RightHand : HandRole.LeftHand, amplitude: 0.45f);
=======
        Debug.Log("Collision: " + collision.collider.name);
>>>>>>> 7cab9024b46e89396d396950c19eea2f33ae1718
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
