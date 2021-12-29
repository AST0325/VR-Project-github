using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("In Game");
    }

    public void EndGame()
    {
#if UNITY_EDITOR
        Debug.Log("EndGame");
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
