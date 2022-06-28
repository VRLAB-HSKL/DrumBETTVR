using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision: " + collision.collider.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
