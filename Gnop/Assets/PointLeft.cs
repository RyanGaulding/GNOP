using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointLeft : MonoBehaviour
{
    private int scoreLeft;
    public TextMeshProUGUI countText;
    // Start is called before the first frame update
    void Start()
    {
        scoreLeft = 0;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ball"))
        {
            scoreLeft++;
        }
    }
}
