using UnityEngine;
using System.Collections;

public class CharacterScript : MonoBehaviour {

    public CharTypeEnum charType;
    public bool isSelected;

	// Use this for initialization
	void Start () {
        charType = CharTypeEnum.None;
        isSelected = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
