using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

    public int money;
    public int playerNumber;
    public GameObject currentCharacter;
    public GameObject[] availableCards;

    // Use this for initialization
    void Start() {
        money = 2;

    }

    // Update is called once per frame
    void Update() {

    }

    public void setCharacter(GameObject charObject, CharTypeEnum charType)
    {
        charObject.transform.position =
            new Vector3(
                currentCharacter.transform.position.x,
                currentCharacter.transform.position.y,
                currentCharacter.transform.position.z
                );
        currentCharacter.SetActive(false);
        currentCharacter = charObject;
        var charScript = currentCharacter.GetComponent(typeof(CharacterScript)) as CharacterScript;

        GUIScript.StartRound(playerNumber);
    }
}