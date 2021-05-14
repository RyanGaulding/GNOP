using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class bigball : MonoBehaviour
{
    public TextMeshProUGUI countText;
    void SetCountText()
    {
        countText.text = "BigBoy";
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("HIT");
        GameObject temp = collision.gameObject;
        temp.transform.localScale = temp.transform.localScale * 5;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        SetCountText();
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
