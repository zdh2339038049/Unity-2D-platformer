using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    public GameObject spikeeffect;
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
            AudioManager.instance.playSFX(0);
            PlayerHealth playerhealth = collision.gameObject.GetComponent<PlayerHealth>();
            playerhealth.DealDamage();
            Instantiate(spikeeffect, transform.position, Quaternion.identity);
        }
    }
}
