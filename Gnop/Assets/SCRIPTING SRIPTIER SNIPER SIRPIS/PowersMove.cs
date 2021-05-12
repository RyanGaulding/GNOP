using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowersMove : MonoBehaviour
{
    GameObject[] powerups;
    // Start is called before the first frame update
    void Start()
    {
        powerups = GameObject.FindGameObjectsWithTag("powerups");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
