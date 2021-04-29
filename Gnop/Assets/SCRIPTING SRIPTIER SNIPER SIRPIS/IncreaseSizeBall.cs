using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseSizeBall : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject temp = collision.gameObject;
        temp.transform.localScale += new Vector3(4, 4, 4);
       
       
        
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
