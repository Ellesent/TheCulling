using UnityEngine;
using System.Collections;

public class andrewSheepScript : MonoBehaviour {

    public GameObject target; //the gameobject that the sheep will run towards.
    public float speed;
    public bool isEscaping;
    private Rigidbody rb;
    private float currentSpeed;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (isEscaping)
        {
            currentSpeed = rb.velocity.magnitude;
            transform.LookAt(target.transform);
            rb.AddRelativeForce(Vector3.forward);

            rb.velocity = new Vector3(transform.forward.x * currentSpeed, transform.forward.y * currentSpeed, transform.forward.z * currentSpeed);

            //float step = speed * Time.deltaTime;
            //transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);
        }
    }
}
