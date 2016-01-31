using UnityEngine;
using System.Collections;

public class SheepWolfManager : MonoBehaviour {

	// Use this for initialization
    public static int wolfTotal; //used to keep track of total wolf points
    public static int sheepTotal; //used to keep track of total sheep points
    public static string name;
    public static int dialogueCount;
    string type;
  public static bool ritualTime;
	void Start () {
        
        //start off with 0 sheep and wolf points
        type = "";
        wolfTotal = 0;
        sheepTotal = 0;
        ritualTime = false;
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(dialogueCount);

        if (dialogueCount == 5)
        {
            if (wolfTotal > sheepTotal)
            {
                type = "Wolf";

            }
            else if (sheepTotal > wolfTotal)
            {
                type = "Sheep";
            }
            else
            {
                type = "Wolf";
            }
            ritualTime = true;
            dialogueCount = 0;
        }
        //Debug.Log("Wolf: " + wolfTotal + " Sheep: " + sheepTotal);
	
	}
}
