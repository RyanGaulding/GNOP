using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    // Start is called before the first frame update
    private float m_waitInSeconds = 5.0f;
    private float StartTime = 0.0f;
    public GameObject playerObject = null;

    void Start()
    {
        // The time at this very moment, plus the 100 seconds we want to wait.
        StartTime = 4.0f;
        StartTime -= Time.deltaTime;
    }

    
}
