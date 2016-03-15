using UnityEngine;
using System.Collections.Generic;

public class CardSelectScript : MonoBehaviour {

    public Stack<GameObject> cardsStack;
    public GameObject[] availableCardTypes;
    public int canDrawCards;

	// Use this for initialization
	void Start () {
        this.cardsStack = new Stack<GameObject>();
        this.canDrawCards = 0;
        // TODO: Shuffle
        foreach (var card in availableCardTypes)
        {
            cardsStack.Push(card);
        }
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnMouseDown()
    {
        if (this.canDrawCards > 0)
        {
            this.canDrawCards--;
            var card = cardsStack.Pop();
            var player = GameObject.FindObjectOfType<PlayerScript>();
            player.takeCard(card);
        }
    }
}
