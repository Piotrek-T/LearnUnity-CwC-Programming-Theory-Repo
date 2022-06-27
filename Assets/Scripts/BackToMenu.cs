using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    [SerializeField] private GameObject player;

    public void StartMenu()
    {
        GameManagement.Instance.SetScore(player.GetComponent<PlayerContoller>().GetScore());
        SceneManager.LoadScene(0);
    }
}
