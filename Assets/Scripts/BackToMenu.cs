using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    [SerializeField] private TMP_Text score;

    public void StartMenu()
    {
        GameManagement.Instance.SetScore(score);
        GameManagement.Instance.ActivateScoreText();
        SceneManager.LoadScene(0);
    }
}
