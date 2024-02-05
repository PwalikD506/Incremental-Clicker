using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialUpgrade : MonoBehaviour
{
    [SerializeField] GameObject specialUpgrade;

    Upgrades upgrades;

    public void Start()
    {
        upgrades = GetComponent<Upgrades>();
    }
}
