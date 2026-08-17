using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public int Score;
    public int ScoreAmount;
    public GameObject scoreeffect;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
        scoreText.text = "SCORE: " + Score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin") 
        {
            AudioManager.instance.playSFX(2);
            Score += ScoreAmount;
            scoreText.text = "SCORE: " + Score;
            Destroy(collision.gameObject);
            Instantiate(scoreeffect, transform.position, Quaternion.identity);
        }
    }
}
