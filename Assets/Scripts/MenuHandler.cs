using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MenuHandler : MonoBehaviour
{
    [SerializeField]
    protected GameObject scorePanel;
    
    [SerializeField]
    protected TMP_Text scoreText;
    
    private void Update()
    {
        UpdateScore();
    }
    
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
    
    public void UpdateScore()
    {
        if (GameManagement.Instance.GetScore() > 0 )
        {   
            scorePanel.SetActive(true);
        }

        scoreText.text = "Your score is: " + GameManagement.Instance.GetScore();
    }
}
