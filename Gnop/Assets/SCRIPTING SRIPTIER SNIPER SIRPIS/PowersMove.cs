using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowersMove : MonoBehaviour
{
    private GameObject[] powerups;
    float oneSecond = 0;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        powerups = GameObject.FindGameObjectsWithTag("powerup");
        foreach(GameObject i in powerups)
        {
            i.SetActive(false);
        }
        //-4<x<55
        //-24<y<24
        foreach(GameObject i in powerups)
        {
            int xNew = UnityEngine.Random.Range(-4, 25);
            int yNew = UnityEngine.Random.Range(-22, 22);
            i.transform.position = new Vector3(xNew, yNew, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (oneSecond >= 1&&count<powerups.Length)
        {
            powerups[count].SetActive(true);
            oneSecond = 0;
            count++;
        }
        if (count < powerups.Length)
        {
            oneSecond += Time.deltaTime;
        }
    }
}
