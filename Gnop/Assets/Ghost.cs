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
        StartTime = Time.time + m_waitInSeconds;
    }

    void Update()
    {
        // Wait until its time
        if (StartTime <= Time.time)
        {
            
            // Make it visible
            if (GetComponent<Renderer>().enabled == false)
            {
                GetComponent<Renderer>().enabled = true;
            }
            else // Make it invisible
            {
                GetComponent<Renderer>().enabled = false;
            }
            // Make it wait another 100 seconds until we switch it again.
            StartTime = Time.time + m_waitInSeconds;
        }

    }
}
