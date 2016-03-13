using UnityEngine;
using System.Collections;

public class CharacterScript : MonoBehaviour {

    public CharTypeEnum charType;
    public Sprite None;
    public Sprite Killer;
    public Sprite Theif;
    public Sprite Religious;
    public Sprite King;
    public Sprite Merchant;
    public Sprite Wizard;
    public Sprite Builder;
    public Sprite Warrior;

    // Use this for initialization
    void Start () {
        //charType = CharTypeEnum.None;
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnMouseDown()
    {
        var player = GameObject.FindObjectOfType<PlayerScript>();
        player.setCharacter(gameObject, charType);
        //charType = CharTypeEnum.King;
        //gameObject.GetComponent<SpriteRenderer>().sprite = King;
    }

    public void SetCharType(CharTypeEnum newCharType)
    {
        this.charType = newCharType;
        switch (charType)
        {
            case CharTypeEnum.Killer:
                gameObject.GetComponent<SpriteRenderer>().sprite = Killer;
                break;
            case CharTypeEnum.Theif:
                gameObject.GetComponent<SpriteRenderer>().sprite = Theif;
                break;
            case CharTypeEnum.Religious:
                gameObject.GetComponent<SpriteRenderer>().sprite = Religious;
                break;
            case CharTypeEnum.King:
                gameObject.GetComponent<SpriteRenderer>().sprite = King;
                break;
            case CharTypeEnum.Merchant:
                gameObject.GetComponent<SpriteRenderer>().sprite = Merchant;
                break;
            case CharTypeEnum.Wizard:
                gameObject.GetComponent<SpriteRenderer>().sprite = Wizard;
                break;
            case CharTypeEnum.Builder:
                gameObject.GetComponent<SpriteRenderer>().sprite = Builder;
                break;
            case CharTypeEnum.Warrior:
                gameObject.GetComponent<SpriteRenderer>().sprite = Warrior;
                break;
        }
    }
}
