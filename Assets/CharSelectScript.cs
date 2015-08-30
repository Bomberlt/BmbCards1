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
        var positionX = gameObject.transform.position.x - (GetComponent<Renderer>().bounds.size.x / 4);
        foreach (var character in this.characters)
        {
            character.isSelected = false;
            var pos = gameObject.transform.position;
            pos.x += positionX;
            positionX += 1.7f;
            var a = Instantiate(character.spawnThis, pos, gameObject.transform.rotation) as GameObject;
            var b = a.GetComponent(typeof(CharacterScript)) as CharacterScript;
            b.SetCharType(character.charType);
        }
    }
}
