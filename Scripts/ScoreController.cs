using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.UI;


public class ScoreController : MonoBehaviour
{
    public ObjectCreatorScriptableObject objectCreator;
    private int score;
    public Text ScoreText;

    public void Awake()
    {
        objectCreator.scoreController = this;
    }

    public void AddScore(int scoreAmount)
    {
        score += scoreAmount;
        ScoreText.text = score.ToString();
    }

    
}
