using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

    public int money;
    public Character currentCharacter;
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
                currentCharacter.spawnThis.transform.position.x,
                currentCharacter.spawnThis.transform.position.y,
                currentCharacter.spawnThis.transform.position.z
                );
        currentCharacter.spawnThis.SetActive(false);
        currentCharacter.spawnThis = charObject;
        currentCharacter.charType = charType;
    }
}