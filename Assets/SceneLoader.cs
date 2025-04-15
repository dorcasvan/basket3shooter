using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadBasketballGame()
    {
        SceneManager.LoadScene("Basketball game");
    }
}