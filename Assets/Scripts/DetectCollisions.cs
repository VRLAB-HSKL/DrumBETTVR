<<<<<<< HEAD
using HTC.UnityPlugin.Vive;
using UnityEngine;
=======
<<<<<<< HEAD
using HTC.UnityPlugin.Vive;
using UnityEngine;
=======
<<<<<<< HEAD
using HTC.UnityPlugin.Vive;
using UnityEngine;
=======
using UnityEngine;

>>>>>>> 7cab9024b46e89396d396950c19eea2f33ae1718
>>>>>>> 1b5634936a05422c964341228625f967c851da4a
>>>>>>> 4a02ba4dd0222e557b5c07c1cf3438f40bdc4790
public class DetectCollisions : MonoBehaviour
{
    
    // Start is called before the first frame update
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 1b5634936a05422c964341228625f967c851da4a
>>>>>>> 4a02ba4dd0222e557b5c07c1cf3438f40bdc4790
    AudioSource ac;
    void Start()
    {
        ac = GetComponent<AudioSource>(); 
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
=======
    void Start()
    {
        
>>>>>>> 7cab9024b46e89396d396950c19eea2f33ae1718
>>>>>>> 1b5634936a05422c964341228625f967c851da4a
>>>>>>> 4a02ba4dd0222e557b5c07c1cf3438f40bdc4790
    }
    
    void OnCollisionEnter(Collision collision)
    {
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 4a02ba4dd0222e557b5c07c1cf3438f40bdc4790
        if (collision.collider.GetComponent<PositionTracker>().positionDelta.y < 0) return;
        Debug.Log("Collision: " + collision.collider.tag);
            
        ac.PlayOneShot(ac.clip);
       
        if (collision.collider.CompareTag("Right"))
        {
            ViveInput.TriggerHapticVibrationEx(HandRole.RightHand, amplitude: 0.45f);
        }
        else if (collision.collider.CompareTag("Left"))
        {
            ViveInput.TriggerHapticVibrationEx(HandRole.LeftHand, amplitude: 0.45f);
        }
<<<<<<< HEAD
=======
=======
<<<<<<< HEAD
        Debug.Log("Collision: " + collision.collider.tag);
        ac.PlayOneShot(ac.clip);
        ViveInput.TriggerHapticVibrationEx(
            collision.collider.CompareTag("Right") ? HandRole.RightHand : HandRole.LeftHand, amplitude: 0.45f);
=======
        Debug.Log("Collision: " + collision.collider.name);
>>>>>>> 7cab9024b46e89396d396950c19eea2f33ae1718
>>>>>>> 1b5634936a05422c964341228625f967c851da4a
>>>>>>> 4a02ba4dd0222e557b5c07c1cf3438f40bdc4790
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
        
>>>>>>> 1b5634936a05422c964341228625f967c851da4a
>>>>>>> 4a02ba4dd0222e557b5c07c1cf3438f40bdc4790
    }
}
