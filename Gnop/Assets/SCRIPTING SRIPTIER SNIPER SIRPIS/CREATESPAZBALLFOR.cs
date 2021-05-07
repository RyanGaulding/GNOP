using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CREATESPAZBALLFOR : MonoBehaviour
{
    private float StartTime = 0.0f;
    GameObject temp;
    public bool hit = false;
    public bool check = false;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
      
        
       temp = collision.gameObject;
        Vector3 p = temp.transform.position;
        StartTime = 4.0f;
        hit = true;
        transform.position = new Vector3(100, 100, 100);
        
       
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
      //  Destroy(gameObject);
    }
    void FixedUpdate()
    {
      
        if(check)
        {
            if (Random.Range(0, 100) == 3)
            {
                temp.transform.position = new Vector3(Random.Range(-20f, 20f), Random.Range(-10f, 10f), 0);
                check = false;
            }
        }
        if(hit)
                {
            //print("CHECKING");
            if (Random.Range(0, 10) == 5)
            {
                check = true;
            }
        }
       
       
    }
}
