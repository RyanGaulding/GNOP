using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clearballssAsdfGfdsa : MonoBehaviour
{
    // Start is called before the first frame update
    private bool check;
    GameObject temp;
    SpriteRenderer rasdf;
    Color newColor;
    public int count = 0;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("HEY");
        temp = collision.gameObject;
        rasdf = temp.GetComponent<SpriteRenderer>();
        newColor = rasdf.material.color;
        newColor.a = 0;
        rasdf.material.color = newColor;
        check = true;

    }
    private void FixedUpdate()
    {
        print(check);
        print(count);
        if(check)
        {
            check = true;
            count++;
        }
        if(count >=5)
        {
            rasdf = temp.GetComponent<SpriteRenderer>();
            newColor = rasdf.material.color;
            newColor.a = 100;
            rasdf.material.color = newColor;
            count = 0;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        
        Destroy(gameObject);
    }
}
