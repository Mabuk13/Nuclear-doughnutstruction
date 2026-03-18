using System;
using UnityEngine;

public class ClickToQuit : MonoBehaviour
{
    private void OnMouseDown()
    {
        QuitGame();
    }

    private void QuitGame()
    {
        Debug.Log("Game is closing...");

        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; 
        #else
        Application.Quit();
        #endif 
    }
}
