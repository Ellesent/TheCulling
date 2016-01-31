using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SheepOrWolfDialogue : MonoBehaviour {
    //decides how many points each dialogue option is worth
    public int wolf;
    public int sheep;
    public GameObject background;
    public Text replyText;
   public static bool finalText;
   public GameObject sound;
   public AudioSource npc;
   public AudioSource npc1;
   public AudioSource npc2;
  
    float time;

	// Use this for initialization
	void Start () {
        time = 5;
        finalText = false;
        if (GameObject.Find("Friend") != null)
        {
        npc = GameObject.Find("Friend").GetComponent<AudioSource>();
        }
        if (GameObject.Find("Sneaky") != null)
        {
            npc1 = GameObject.Find("Sneaky").GetComponent<AudioSource>();
        }

        if (GameObject.Find("Leader") != null)
        {
            npc2 = GameObject.Find("Leader").GetComponent<AudioSource>();
        }
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(time);
        //Debug.Log(finalText);
        if (finalText == true)
        {
            time -= Time.deltaTime;
            //Debug.Log(time);

        }
        if (time <= 0)
        {
            Debug.Log("YAY");
            
            
                replyText.text = "";
            
            finalText = false;
            Destroy(background);
            time = 5;
        }
	
	}

    public void OnClick(string reply)
    {
        //when a dialogue option is clicked, add the points of that option to the total amount of points the player has
        Time.timeScale = 1;
        finalText = true;
        SheepWolfManager.wolfTotal += wolf;
        SheepWolfManager.sheepTotal += sheep;
        reply = reply.Replace("NEWLINE", "\n");
       // replyText.text = "";
        replyText.text = reply;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Instantiate(sound);
        if (background.name == "FriendDialogue" &&  npc != null)
        {
            Destroy(npc);
        }
        if (background.name == "SneakDialogue" && npc1 != null)
        {
            Destroy(npc1);
        }
        if (background.name == "LeaderDialogue" && npc2 != null)
        {
            Destroy(npc2);
        }
        background.GetComponent<RectTransform>().anchoredPosition = new Vector2(500, 500);
        
        
    }

    
      
}
