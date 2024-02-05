using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Upgrades : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI upgradedPrice;
    [SerializeField] TextMeshProUGUI amountOfUpgradesText;

    [SerializeField] float buyPrice;
    [SerializeField] int howMuchMorePerSecond;

    [SerializeField] ScoreManager scoreManager;

    float amountOfUpgrades;
    bool initializedValue = true;

    public void Upgrade(float originalCost)
    {
        if (initializedValue)
        {
            buyPrice = originalCost;
            initializedValue = false;
        }

        if (scoreManager.score >= buyPrice)
        {
            scoreManager.score -= buyPrice;
            scoreManager.scoreText.text = scoreManager.score.ToString();

            buyPrice = Mathf.Round(buyPrice * 1.2f);
            upgradedPrice.text = buyPrice.ToString();

            amountOfUpgrades++;


