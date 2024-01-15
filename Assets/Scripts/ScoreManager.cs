using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI perSecondText;
    [SerializeField] TextMeshProUGUI upgradePrice;
    [SerializeField] TextMeshProUGUI amountOfUpgradesText;

    [SerializeField] float buyPrice;

    float score;
    float productionPerSecond;
    float amountOfUpgrades;

    void Start()
    {
        score = 0;
        productionPerSecond = 0;
        InvokeRepeating("NewScore", 0f, 1f);
    }

    void NewScore()
    {
        score = score + productionPerSecond;

        scoreText.text = score.ToString();
    }

    void AddProductionPerSecond()
    {
        productionPerSecond++;

        perSecondText.text = productionPerSecond.ToString();
    }

    public void AddScore()
    {
        score++;

        scoreText.text = score.ToString();
    }

    public void Upgrade()
    {
        if (score >= buyPrice)
        {
            score = score - buyPrice;

            buyPrice = Mathf.Round(buyPrice * 1.2f);

            scoreText.text = score.ToString();

            upgradePrice.text = buyPrice.ToString();

            amountOfUpgrades++;
            amountOfUpgradesText.text = amountOfUpgrades.ToString();

            AddProductionPerSecond();
        }
    }
}
