using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CREATESPAZBALLFOR : MonoBehaviour
{
    private float StartTime = 0.0f;
   

    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
      
        
        GameObject temp = collision.gameObject;
        Vector3 p = temp.transform.position;
        StartTime = 4.0f;
        while (StartTime > 0)
        {
            
        }
        temp.transform.position += new Vector3(Random.Range(-23f, 24f), Random.Range(-13f, 17f), 0);


    }
    private void Start()
    {
       
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
    private void Update()
    {
        StartTime -= Time.deltaTime;
    }
}
