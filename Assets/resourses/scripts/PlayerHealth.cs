using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int currentHealth, maxHealth, damageAmount;
    public GameObject damageeffect;

    public HealthBar healthbar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(currentHealth);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DealDamage()
    {
        currentHealth -= damageAmount;
        healthbar.SetHealth(currentHealth);
        Instantiate(damageeffect, transform.position, Quaternion.identity);
        if (currentHealth <= 0) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}
