using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class UIManager : MonoBehaviour
{

    [Header("Top Bar")]
    public Text scoreText;
    public Text highScoreText;
    public Text movementText;
    public GameObject undoButton;

    [Header("Dialog Menu")]
    public GameObject dialogWindow;
    public Text dialogWindowTitle;
    public Text dialogWindowMessage;
    public Transform dialogWindowButton;

    [Header("Main Menu")]
    public GameObject menuContainer;

    public void MenuButtonClick(int buttonId)
    {
        switch (buttonId)
        {
            case 0:         //Start a new game
                GameManager.instance.runtimeVars.isPaused = true;  // pause the game 
                ShowDialogWindow("New Game", "You will lose current progress, are you sure?",
                    new YesNoButton("Yes", () =>
                    {
                       
                    }),
                    new YesNoButton("No", () =>
                    {
                        
                    }));
                break;
            case 1:           //Show leaderboard
                break;
            case 2:             //Show settings
                break;
            case 3:         //Exit game
                Application.Quit();
                break;
        }
    }


    public class YesNoButton
    {
        public YesNoButton(string _title, UnityAction _onClick)
        {
            title = _title;
            onClick = _onClick;
        }
        public string title;
        public UnityAction onClick;
    }
}
