using UnityEngine;
using System.Collections;
using System;

public class PlayerScript : MonoBehaviour {

    public int money;
    public int playerNumber;

    public GameObject selectedCharacter;
    public GameObject activeCharacter;

    public GameObject cardPlace;
    public GameObject[] availableCards;

    // Use this for initialization
    void Start() {
        money = 2;
        activeCharacter.SetActive(false);
        availableCards = new GameObject[10];
    }

    // Update is called once per frame
    void Update() {

    }

    public void setCharacter(GameObject charObject)
    {
        charObject.transform.position =
            new Vector3(
                selectedCharacter.transform.position.x,
                selectedCharacter.transform.position.y,
                selectedCharacter.transform.position.z
                );
        selectedCharacter.SetActive(false);
        selectedCharacter = charObject;

        var charScript = charObject.GetComponent(typeof(CharacterScript)) as CharacterScript;
        GUIScript.LogStatus(
            "Player no {0} picked character {1}",
            this.playerNumber,
            charScript.charType);

        GUIScript.StartRound(playerNumber);
    }

    public void takeCard(GameObject card)
    {
        card.transform.position =
            new Vector3(
                cardPlace.transform.position.x,
                cardPlace.transform.position.y,
                cardPlace.transform.position.z
                );
        cardPlace.SetActive(false);
        availableCards[0] = card;
        var cardScript = card.GetComponent(typeof(CardScript)) as CardScript;
        GUIScript.LogStatus("Card {0} taken by player no {1}", cardScript.price, this.playerNumber);
    }

    public void playCharacter(GameObject charObject)
    {
        var charScript = charObject.GetComponent(typeof(CharacterScript)) as CharacterScript;
        GUIScript.LogStatus(
            "Player no {0} playing character {1}",
            this.playerNumber,
            charScript.charType);
        charObject.transform.position =
            new Vector3(
                activeCharacter.transform.position.x,
                activeCharacter.transform.position.y,
                activeCharacter.transform.position.z
                );
        activeCharacter = charObject;
    }
}