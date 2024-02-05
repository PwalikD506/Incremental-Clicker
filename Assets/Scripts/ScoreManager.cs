using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI perSecondText;

    public float score;
    public float productionPerSecond;

    void Start()
    {
        InvokeRepeating("NewScore", 0f, 1f);

    }

    void NewScore()
    {
        score = score + productionPerSecond;

        scoreText.text = score.ToString();
    }

    public void AddProductionPerSecond(int howMuchMorePerSecond)
    {
        productionPerSecond = productionPerSecond + howMuchMorePerSecond;

        perSecondText.text = productionPerSecond.ToString();
    }

    public void AddScore()
    {
        score++;

        scoreText.text = score.ToString();
    }
}
