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
        //Debug.Log(powerups.Length);
        foreach(GameObject i in powerups)
        {
            i.SetActive(false);
        }
        //-4<x<55
        //-24<y<24
        foreach(GameObject i in powerups)
        {
            int xNew = UnityEngine.Random.Range(-4, 25);
            int yNew = UnityEngine.Random.Range(-24, 24);
            i.transform.position = new Vector3(xNew, yNew, 0);
            //i.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (oneSecond >= 1&&count<5)
        {
            powerups[count].SetActive(true);
            oneSecond = 0;
            count++;
        }
        oneSecond += Time.deltaTime;
        Debug.Log(oneSecond);
    }
}
