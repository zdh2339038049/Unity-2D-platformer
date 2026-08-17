using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggering : MonoBehaviour
{
    public GameObject spike1, spike2, spike3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") 
        {
            StartCoroutine(SpikeActivation());
        }
    }
    IEnumerator SpikeActivation()
    {
        spike1.SetActive(true);
        yield return new WaitForSeconds(3f);
        spike2.SetActive(true);
        yield return new WaitForSeconds(3f);
        spike3.SetActive(true);
    }
}
