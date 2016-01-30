using UnityEngine;
using System.Collections;

public class SheepWolfManager : MonoBehaviour {

	// Use this for initialization
    public static int wolfTotal; //used to keep track of total wolf points
    public static int sheepTotal; //used to keep track of total sheep points
    public static string name;
	void Start () {
        //start off with 0 sheep and wolf points
        wolfTotal = 0;
        sheepTotal = 0;
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Wolf: " + wolfTotal + " Sheep: " + sheepTotal);
	
	}
}
