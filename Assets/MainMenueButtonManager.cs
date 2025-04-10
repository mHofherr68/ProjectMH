
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenueButtonManager : MonoBehaviour
{
    [SerializeField] private string gameSceneName = "Game";
    public void StartGamePressed()
    {
        Debug.Log("Start Button Pressed");
        SceneManager.LoadScene(gameSceneName);
    }
    public void OptionsPressed()
    {
        Debug.Log("Options Button Pressed");
    }
    public void QitPresed()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

}