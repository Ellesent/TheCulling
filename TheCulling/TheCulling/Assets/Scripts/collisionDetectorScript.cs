using UnityEngine;
using System.Collections;

public class collisionDetectorScript : MonoBehaviour {

    public Rigidbody parentBody;
    public float sideJumpPower;

	// Use this for initialization
	void Start () {
        parentBody = GetComponentInParent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter()
    {
        Debug.Log("Triggered");
        parentBody.AddRelativeForce(Vector3.left * sideJumpPower);
    }
}
