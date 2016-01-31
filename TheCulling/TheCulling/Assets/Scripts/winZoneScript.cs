using UnityEngine;
using System.Collections;

public class winZoneScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider collider)
    {
        Debug.Log(collider.tag);
    }
}
