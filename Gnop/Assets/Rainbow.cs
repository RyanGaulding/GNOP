using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Rainbow : MonoBehaviour
{
    GameObject temp;
    public bool hit = false;
    public TextMeshProUGUI countText;
    // Start is called before the first frame update
    public float timer = 0.0f;
    void Start()
    {
        
    }
   
    // Update is called once per frame
    void Update()
    {
        print("hey");

        timer += Time.deltaTime;
        if (timer >= 0.5f)//change the float value here to change how long it takes to switch.
        {
            if(hit)
            {
                TrailRenderer err = temp.GetComponent<TrailRenderer>();
                err.material.color = new Color(Random.value, Random.value, Random.value, 1.0f);
                Renderer rend = temp.GetComponent<Renderer>();
                // pick a random color
                Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
                // apply it on current object's material
                rend.material.color = newColor;
            }
           
            timer = 0;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        transform.position = new Vector3(100, 100, 100);
        hit = true;
         temp = collision.gameObject;
       
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        SetCountText();
       // Destroy(gameObject);
    }
    void SetCountText()
    {
        countText.text = "RainBow";
    }
}
