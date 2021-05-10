using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class FastBall : MonoBehaviour
{
    public TextMeshProUGUI countText;
    
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject temp = collision.gameObject;
        temp.GetComponent<Ball>().increaseSpeed();
        
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        SetCountText();
        Destroy(gameObject);
    }
    void SetCountText()
    {
        countText.text = "FASTBALL";
    }

}
