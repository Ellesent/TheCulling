using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InputFieldBehavior : MonoBehaviour {
     

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //called when the user is finished editing the input field
    public void EndEdit(InputField name)
    {
        //if there is nothing in the input field, ask them to enter a name
        if (name.text.Length < 1)
        {
            name.placeholder.GetComponent<Text>().text = "Please enter a name";

        }
        else
        {
            //else save the player's name and load the game
            SheepWolfManager.name = name.text;
            Application.LoadLevel(1);
        }
    }
}
