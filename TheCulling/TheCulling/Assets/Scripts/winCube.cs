using UnityEngine;
using System.Collections;

public class winCube : MonoBehaviour {

    public float activationDistance; //Recommendation = 10
    public GameObject player;
    private float currentDistance;
    private bool win;

	// Use this for initialization
	void Start () {
        win = false;
	}
	
    void FixedUpdate()
    {
        currentDistance = Vector3.Distance(this.transform.position, player.transform.position);
        if(currentDistance <= activationDistance )
        {
            win = true;
            Debug.Log("You Win!");
        }
    }
}
