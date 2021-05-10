using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PointLeft : MonoBehaviour
{
    private int scoreLeft;
    public TextMeshProUGUI countText;
    // Start is called before the first frame update
    void Start()
    {
        scoreLeft = 0;

        SetCountText();
    }

    void SetCountText()
    {
        countText.text = "Score " + scoreLeft.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(!collision.CompareTag("wall"))
        {
            scoreLeft++;
            SetCountText();
        }
        
        if(scoreLeft == 5)
        {
            SceneManager.LoadScene("EndScreen");
        }
    
    }

}
