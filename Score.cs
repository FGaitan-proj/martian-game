using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public float score;
    public float bombs;
    public float Martians;
    public float AttackPower;
    [Range(2.0f,10.0f)]
    public float DistancebMart = 5.0f;
    public TextMeshProUGUI textMeshScore;
    public TextMeshProUGUI textMeshBomb;
    public TextMeshProUGUI textMeshMartians;

    private void Update()
    {
        textMeshScore.text = "Score: " + score;
        textMeshBomb.text = "Bombs: " + bombs;
        textMeshMartians.text = "Martian: " + Martians;

    }
}
