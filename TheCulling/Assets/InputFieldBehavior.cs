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
    public void EndEdit(InputField name)
    {
        if (name.text.Length < 1)
        {
            name.placeholder.GetComponent<Text>().text = "Please enter a name";

        }
        else
        {
            SheepWolfManager.name = name.text;
            Application.LoadLevel(1);
        }
    }
}
