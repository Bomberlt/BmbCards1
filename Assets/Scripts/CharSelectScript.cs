using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class CharSelectScript : MonoBehaviour {

    public GameObject[] charactersToSpawn;
    public List<GameObject> charsObjs;
    public GameObject background;

	// Use this for initialization
	void Start ()
    {
        background.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
    }

    public void InitCharSelect()
    {
        background.SetActive(true);
        var charTypes = new[]
        {
            CharTypeEnum.Killer,
            CharTypeEnum.Theif,
            CharTypeEnum.Religious,
            CharTypeEnum.King,
            CharTypeEnum.Merchant,
            CharTypeEnum.Wizard,
            CharTypeEnum.Builder,
            CharTypeEnum.Warrior,
        }.GetEnumerator();
        charTypes.MoveNext();

        var nextCharPosX = gameObject.transform.position.x - (GetComponent<Renderer>().bounds.size.x / 4);
        foreach (var character in this.charactersToSpawn)
        {
            var charPos = gameObject.transform.position;
            charPos.x += nextCharPosX;
            nextCharPosX += 1.7f;
            var characterObj = Instantiate(
                        character, 
                        charPos, 
                        gameObject.transform.rotation) as GameObject;

            var charScript = characterObj.GetComponent(typeof(CharacterScript)) as CharacterScript;
            charScript.isSelected = false;
            charScript.isPlayed = false;

            charScript.SetCharType((CharTypeEnum)charTypes.Current);
            charTypes.MoveNext();

            this.charsObjs.Add(characterObj);
        }
    }

    public void FlopUnselectedChars()
    {
        foreach (var characterObj in this.charsObjs)
        {
            var charScript = characterObj.GetComponent(typeof(CharacterScript)) as CharacterScript;
            if (!charScript.isSelected)
            {
                characterObj.SetActive(false);
            }
        }
    }
}
