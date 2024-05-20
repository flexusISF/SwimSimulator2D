using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Score());
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString(); 
    }
    IEnumerator Score()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.8f);
            score = score + 1;
            Debug.Log("Score: " + score);
        }
    }
}
