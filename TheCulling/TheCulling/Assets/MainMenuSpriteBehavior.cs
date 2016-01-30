using UnityEngine;
using System.Collections;

public class MainMenuSpriteBehavior : MonoBehaviour {

    public Sprite openEnvelope;
    public GameObject text;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void OnEnvelopeClick(GameObject closedEnvelope)
    {
        //change sprite of envelope and destroy the beginning text 
        closedEnvelope.GetComponent<SpriteRenderer>().sprite = openEnvelope;
        Destroy(text);
    }
}
