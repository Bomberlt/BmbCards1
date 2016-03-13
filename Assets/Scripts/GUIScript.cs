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
        statusText.text = "Starting";
        var charSelect = GameObject.FindObjectOfType<CharSelectScript>();
        charSelect.InitCharSelect();
    }

    public static void StartRound(int playerNumber)
    {
        var charSelect = GameObject.FindObjectOfType<CharSelectScript>();
        charSelect.FlopUnselectedChars();
        // TODO: Set players turns
        PlayerTurn(playerNumber);
    }

    public static void PlayerTurn(int playerNumber)
    {
        var cardSelect = GameObject.FindObjectOfType<CardSelectScript>();
        cardSelect.canDrawCards = CardDrawPerTurn;
    }
}
