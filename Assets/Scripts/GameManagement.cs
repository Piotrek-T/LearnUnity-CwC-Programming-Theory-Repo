using UnityEngine;

public class GameManagement : MonoBehaviour
{
    private int m_Score;

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

    public void SetScore(int setScore)
    {
        m_Score = setScore;
    }
    
    public int GetScore()
    {
        return m_Score;
    }
}
