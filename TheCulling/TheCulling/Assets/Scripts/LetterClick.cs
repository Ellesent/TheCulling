using UnityEngine;
using System.Collections;

public class LetterClick : MonoBehaviour {
    public Sprite RSVP;
    public GameObject input;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = RSVP;
        GetComponent<Collider2D>().enabled = false;
       GameObject bob =  Instantiate(input) as GameObject;
        bob.transform.SetParent(GameObject.Find("Canvas").transform);
        bob.GetComponent<RectTransform>().anchoredPosition = new Vector2(-59, -39);

    }
}
