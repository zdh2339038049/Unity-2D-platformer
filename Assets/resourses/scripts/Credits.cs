using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public GameObject CreditsPanel;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreditRun());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CreditRun()
    {
        yield return new WaitForSeconds(0.5f);
        CreditsPanel.SetActive(true);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(0);
    }
}
