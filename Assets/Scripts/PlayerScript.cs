using UnityEngine;
using System.Collections;
using System;

public class PlayerScript : MonoBehaviour {

    public int money;
    public int playerNumber;
    public GameObject selectedCharacter;
    public GameObject activeCharacter;
    public GameObject[] availableCards;


    // Use this for initialization
    void Start() {
        money = 2;
        activeCharacter.SetActive(false);
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

        GUIScript.StartRound(playerNumber);
    }

    internal void playCharacter(GameObject charObject)
    {
        charObject.transform.position =
            new Vector3(
                activeCharacter.transform.position.x,
                activeCharacter.transform.position.y,
                activeCharacter.transform.position.z
                );
        activeCharacter = charObject;
    }
}