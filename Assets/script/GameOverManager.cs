using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    // Reference to the game over panel UI element
    public GameObject gameOverPanel;

    // Function to activate the game over panel
    public void ShowGameOverPanel()
    {
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);
        }
      
    }

    // Function to restart the game
    public void RestartGame()
    {
        // Implement your game restart logic here
        // For example, you can reload the current scene
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Function to quit the game
    public void QuitGame()
    {
        // Implement your game quit logic here
        // For example, you can quit the application
        // Application.Quit();
    }
}
