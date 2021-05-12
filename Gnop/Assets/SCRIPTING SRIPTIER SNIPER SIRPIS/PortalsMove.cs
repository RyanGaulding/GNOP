using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalsMove : MonoBehaviour
{
    public bool goingUp = true;
    const float top = 20.3f;
    const float bottom = -21f;
    // Start is called before the first frame update
    void Start()
    {
        GameObject portal = GameObject.Find("Orange Portal (1)");
        Vector3 where = portal.GetComponent<Transform>().localPosition;
        transform.localPosition.Set(where.x,where.y,where.z);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float y = transform.position.y;
        //if (y < top && y > bottom)
        //{
            if (goingUp)
            {
                transform.localPosition += new Vector3(0, 10f * Time.deltaTime, 0);
            }
            else
                transform.localPosition += new Vector3(0, -10f * Time.deltaTime, 0);
        //}
        if (y == top || y == bottom||y>top||y<bottom)
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
