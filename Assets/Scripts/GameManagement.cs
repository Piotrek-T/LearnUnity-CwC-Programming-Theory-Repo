using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    
    [SerializeField]
    protected GameObject YourScore;

    private int score;
    
    public static GameManagement Instance;
    
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    
    public void SetScore(TMP_Text score)
    {
        YourScore.GetComponent<TMP_Text>().text = "Your score is: " + score;
    }
    public void ActivateScoreText()
    {
        YourScore.SetActive(true);
    }

}
