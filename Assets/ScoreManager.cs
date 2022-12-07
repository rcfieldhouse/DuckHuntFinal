using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ScoreManager : MonoBehaviour
{
    public float TimeLimit = 0;
    public static ScoreManager instance;
    private int score=0;
    private TextMeshProUGUI text = null;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        text = GameObject.Find("Canvas").GetComponentInChildren<TextMeshProUGUI>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (TimeLimit > 45.0f&&score<10)
        {
            text.text = "you loose";
        }
        TimeLimit += Time.deltaTime;
    }
    public void IncreaseScore()
    {
        score++;
        RenderScore();
    }
    private void RenderScore()
    {
        text.text = score.ToString();
        if (score >= 10)
        {
            text.text = "you win";
        }
        
    }
}
