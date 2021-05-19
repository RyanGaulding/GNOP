using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class PointRight : MonoBehaviour
{
    private int scoreRight;
    public TextMeshProUGUI countText;
    // Start is called before the first frame update
    void Start()
    {
        scoreRight = 0;

        SetCountText();
    }

    void SetCountText()
    {
        countText.text = "Score " + scoreRight.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!collision.CompareTag("wall"))
        {
            scoreRight++;
            SetCountText();
        }

        if (scoreRight == 5)
        {
            SceneManager.LoadScene("EndScreen");
            Task.Delay(5000);
            //Application.Quit();
        }
    }
}
