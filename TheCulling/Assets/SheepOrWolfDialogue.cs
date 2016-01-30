using UnityEngine;
using System.Collections;

public class SheepOrWolfDialogue : MonoBehaviour {
    //decides how many points each dialogue option is worth
    public int wolf;
    public int sheep;

	// Use this for initialization
	void Start () {
       
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

   public void OnClick()
    {
       //when a dialogue option is clicked, add the points of that option to the total amount of points the player has
        SheepWolfManager.wolfTotal += wolf;
        SheepWolfManager.sheepTotal += sheep; 
    }
}
