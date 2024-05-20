using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenuPanel; // Reference to your main menu panel in the scene

    // Start is called before the first frame update
    void Start()
    {
        // Ensure the main menu panel is active when the game starts
        mainMenuPanel.SetActive(true);
    }

    // Method to be called when the Play button is clicked
    public void PlayButtonClicked()
    {
        // Disable the main menu panel
        mainMenuPanel.SetActive(false);
    }
}
