using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingObstacles : MonoBehaviour
{
    public Transform pointa, pointb;
    public int speed;
    private Vector3 currenttarget;
    public int rotatespeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == pointa.position)
        {
            currenttarget = pointb.position;
        }
        else if (transform.position == pointb.position)
        {
            currenttarget = pointa.position;
        }
        transform.position = Vector3.MoveTowards(transform.position, currenttarget, speed * Time.deltaTime);
        transform.Rotate(0f, 0f, rotatespeed * Time.deltaTime);
    }
}
