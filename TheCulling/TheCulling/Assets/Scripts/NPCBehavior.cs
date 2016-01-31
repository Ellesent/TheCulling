using UnityEngine;
using System.Collections;

public class NPCBehavior : MonoBehaviour {
    public GameObject friendDialogue;
    public GameObject sneakyDialogue;
    public GameObject leaderDialogue;
    public GameObject braggerDialogue;
    public GameObject gossipDialogue;
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
        if (coll.gameObject.tag == "Player")
        {
            if (name == "Friend")
            {
                dialogue = Instantiate(friendDialogue) as GameObject;
                


            }
            else if (name == "Sneaky")
            {

                dialogue = Instantiate(sneakyDialogue) as GameObject;
               
            }
            else if (name == "LeaderPeep")
            {
                dialogue = Instantiate(leaderDialogue) as GameObject;
            }
            else if (name == "BraggerPeep")
            {
                dialogue = Instantiate(braggerDialogue) as GameObject;
            }
                

            dialogue.transform.SetParent(GameObject.Find("Canvas").transform, false);
            //dialogue.GetComponent<RectTransform>().anchoredPosition = new Vector3();
            SheepWolfManager.dialogueCount += 1;
            Destroy(GetComponent<Collider>());
            coll.transform.LookAt(GetComponent<Collider>().bounds.center);
            transform.LookAt(coll.GetComponent<Collider>().bounds.center);
            GetComponent<AudioSource>().Play();
            Time.timeScale = 0;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

           
        }


    }
}
