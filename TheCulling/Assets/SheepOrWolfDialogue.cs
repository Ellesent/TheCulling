using UnityEngine;
using System.Collections;

public class SheepOrWolfDialogue : MonoBehaviour {
    public int wolf;
    public int sheep;

	// Use this for initialization
	void Start () {
       
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnClick()
    {
        SheepWolfManager.wolfTotal += wolf;
        SheepWolfManager.sheepTotal += sheep; 
    }
}
