using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionTracker : MonoBehaviour
{
    private Vector3 _lastPosition;
    private Vector3 _currentPosition;
    public Vector3 positionDelta = new Vector3(0,0,0);
    
    // Start is called before the first frame update
    void Start()
    {
        _lastPosition = transform.position;
        _currentPosition = _lastPosition;
    }

    // Update is called once per frame
    void Update()
    {
        _currentPosition = transform.position;
        positionDelta = _lastPosition - _currentPosition;
        _lastPosition = _currentPosition;
        
        // Debug.Log("Delta: " + positionDelta.y);
    }
}
