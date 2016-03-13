using UnityEngine;
using System.Collections;

public class CharSelectScript : MonoBehaviour {

    public Character[] characters;

	// Use this for initialization
	void Start ()
    {
    }
	
	// Update is called once per frame
	void Update () {
    }

    public void InitCharSelect()
    {
        var nextCharPosX = gameObject.transform.position.x - (GetComponent<Renderer>().bounds.size.x / 4);
        foreach (var character in this.characters)
        {
            character.isSelected = false;
            var charPos = gameObject.transform.position;
            charPos.x += nextCharPosX;
            nextCharPosX += 1.7f;
            var characterObj = Instantiate(
                        character.spawnThis, 
                        charPos, 
                        gameObject.transform.rotation) as GameObject;
            var charScript = characterObj.GetComponent(typeof(CharacterScript)) as CharacterScript;
            charScript.SetCharType(character.charType);
        }
    }
}
