using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUIScript : MonoBehaviour {

    public Text statusText;
    public Button startButton;

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
}
