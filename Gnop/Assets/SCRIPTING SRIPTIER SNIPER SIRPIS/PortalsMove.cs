using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalsMove : MonoBehaviour
{
    public bool goingUp = true;
    const float top = 23.3f;
    const float bottom = -24f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float y = transform.position.y;
        if (y < top && y > bottom)
        {
            if (goingUp)
            {
                transform.localPosition += new Vector3(0, 100f * Time.deltaTime, 0);
            }
            else
                transform.localPosition += new Vector3(0, -100f * Time.deltaTime, 0);
        }
        if (y == top || y == bottom)
        {
            if (goingUp)
            {
                transform.Translate(new Vector3(0, -1, 0));
            }
            else
            {
                transform.Translate(new Vector3(0, 1, 0));
            }
            goingUp = !goingUp;
        }
    }
}
