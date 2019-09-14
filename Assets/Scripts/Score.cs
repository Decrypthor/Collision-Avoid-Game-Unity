using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text ScoreText;
    private float zstart;
    private double TempScore;
     

    private void Start()
    {
        zstart = player.position.z;
    }
    void Update()
    {

        TempScore = (player.position.z - zstart);
        if (TempScore <= Int32.MaxValue)
            ScoreText.text = Convert.ToInt32(TempScore).ToString();
        else
            ScoreText.text = "You Won";


    }
}
