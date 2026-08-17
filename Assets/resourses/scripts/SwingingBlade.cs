using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingingBlade : MonoBehaviour
{
    public float speed;
    public float angle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float zrotation = Mathf.Sin(Time.time * speed) * angle;
        transform.rotation = Quaternion.Euler(0f, 0f, zrotation);
    }
}
