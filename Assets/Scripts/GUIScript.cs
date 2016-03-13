using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class GUIScript : MonoBehaviour {

    public Text statusText;
    public Button startButton;

    private const int CardDrawPerTurn = 2;

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {

    }


    public void StartGame () {
        startButton.enabled = false;
        startButton.GetComponentInChildren<CanvasGroup>().alpha = 0;
        GUIScript.LogStatus("Starting game");
        var charSelect = GameObject.FindObjectOfType<CharSelectScript>();
        charSelect.InitCharSelect();
    }

    public static void StartRound(int playerNumber)
    {
        GUIScript.LogStatus("Starting round");
        var charSelect = GameObject.FindObjectOfType<CharSelectScript>();
        charSelect.FlopUnselectedChars();
        // TODO: Set players turns
        PlayerTurn(playerNumber);
    }

    public static void PlayerTurn(int playerNumber)
    {
        GUIScript.LogStatus("Player {0} turn", playerNumber);
        var cardSelect = GameObject.FindObjectOfType<CardSelectScript>();
        cardSelect.canDrawCards = CardDrawPerTurn;
    }

    public static void LogStatus(string text, params object[] moreText)
    {
        var fullText = string.Format(text, moreText);
        Debug.Log(fullText);
        var gui = GameObject.FindObjectOfType<GUIScript>();
        gui.statusText.text = fullText;
    }
}
