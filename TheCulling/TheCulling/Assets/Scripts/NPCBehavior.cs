using UnityEngine;
using System.Collections;

public class NPCBehavior : MonoBehaviour {
    public GameObject friendDialogue;
    public GameObject sneakyDialogue;
    public GameObject leaderDialogue;
    GameObject dialogue;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       // Debug.Log(SheepWolfManager.dialogueCount);
	
	}

    void OnTriggerEnter(Collider coll)
    {
        if (name == "Friend" && coll.gameObject.tag == "Player")
        {
            dialogue = Instantiate(friendDialogue) as GameObject;
            dialogue.transform.SetParent(GameObject.Find("Canvas").transform, false);
            //dialogue.GetComponent<RectTransform>().anchoredPosition = new Vector3();
            SheepWolfManager.dialogueCount += 1;
            Destroy(GetComponent<Collider>());
            coll.transform.LookAt(GetComponent<Collider>().bounds.center);
            transform.LookAt(coll.GetComponent<Collider>().bounds.center);
            Time.timeScale = 0;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
           
            
        }


    }
}
