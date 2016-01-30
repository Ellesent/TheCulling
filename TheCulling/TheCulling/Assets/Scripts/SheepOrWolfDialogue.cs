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
    float time;

	// Use this for initialization
	void Start () {
        time = 3;
	
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(finalText);
        if (finalText == true)
        {
            time -= Time.deltaTime;
            //Debug.Log(time);

        }
        if (time <= 0)
        {
            Destroy(replyText);
        }
	
	}

    public void OnClick(string reply)
    {
        //when a dialogue option is clicked, add the points of that option to the total amount of points the player has
        finalText = true;
        SheepWolfManager.wolfTotal += wolf;
        SheepWolfManager.sheepTotal += sheep;
        Destroy(background);
        reply = reply.Replace("NEWLINE", "\n");
        replyText.text = reply;
        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
      
}
