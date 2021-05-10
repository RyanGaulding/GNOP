using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CREATESPAZBALLFOR : MonoBehaviour
{
    GameObject temp;
    public bool hit = false;
    public TextMeshProUGUI countText;
    public bool check = false;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        temp = collision.gameObject;
        Vector3 p = temp.transform.position;
        hit = true;
        transform.position = new Vector3(100, 100, 100);
    }
    
    void SetCountText()
    {
        countText.text = "SpazAttack";
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        SetCountText();
    }
    void FixedUpdate()
    {
        //print("CHECKING");
        if (check)
        {
            if (Random.Range(0, 100) == 3)
            {
                temp.transform.position = new Vector3(Random.Range(-20f, 20f), Random.Range(-10f, 10f), 0);
                check = false;
            }
        }
        if(hit)
        {
            
            if (Random.Range(0, 10) == 5)
            {
                check = true;
            }
        }
       
       
    }
}
