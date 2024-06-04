using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public int highScore;
    public TextMeshProUGUI scoreText;
    public static int lastScore = 0;
    public TextMeshProUGUI lastScoreText;
    public TextMeshProUGUI highScoreText;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Score());
        
        highScore = PlayerPrefs.GetInt("high_score");

        highScoreText.text = "HighScore:" + highScore.ToString();
        lastScoreText.text = "LastScore:" + lastScore.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        
        if(score>highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("high_score", highScore);
            Debug.Log("High Score:" + highScore);
           
        }
    }
    IEnumerator Score()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.8f);
            score = score + 1;
            lastScore = score;
            
        }
    }
    IEnumerator Reload()
    {
        yield return new WaitForSeconds(Random.Range(5,10));
        SceneManager.LoadScene("");
    }
}
