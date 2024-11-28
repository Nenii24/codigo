using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    
    public AudioSource missSFX;
    public TMPro.TextMeshPro scoreText;
    public TMPro.TextMeshPro multiplierText;
    public TMPro.TextMeshPro streakText;
    static int totalScore;  
    static int streak;
    static int multiplier;
    static int comboScore;
    static int puntos =20;
    static int score;
    void Start()
    {
        Instance = this;
        comboScore = 0;
        streak=0;
        multiplier=1;
        score=0;

    }
    public static void Hit()
    {
        
        score= score+puntos;
        streak++;
        if(streak>=24)
            multiplier=4;
        else if(streak>=16)
            multiplier=3;
        else if (streak>=8)
            multiplier=2;
        else
            multiplier=1;
        comboScore = score*multiplier;
        totalScore = score+comboScore;

    
    }

    public static void Miss()
    {
        
        streak=0;
        multiplier=0;
        Instance.missSFX.Play(); 
    }



    private void Update()
    {
        totalScore = score+comboScore;
        scoreText.text = totalScore.ToString();
        multiplierText.text = multiplier.ToString();
        streakText.text = streak.ToString();
    }


}