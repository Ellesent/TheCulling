using UnityEngine;
using System.Collections;

public class andrewSheepScript : MonoBehaviour {

    public GameObject target; //the gameobject that the sheep will run towards.
    public float speed;
    public bool isEscaping;
    private Rigidbody rb;
    private float currentSpeed;
    public float speedThreshold;
    public float sideJumpForce;
    public float sideFriction;
    private bool dead;



// Use this for initialization
void Start () {
        rb = GetComponent<Rigidbody>();
        dead = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (isEscaping)
        {
            currentSpeed = rb.velocity.magnitude;
            transform.LookAt(target.transform);
            rb.AddRelativeForce(Vector3.forward);

            if (rb.velocity.magnitude > speedThreshold)
            {
                //rb.velocity = new Vector3(transform.forward.x * currentSpeed, transform.forward.y * currentSpeed, transform.forward.z * currentSpeed);
            }

            //side velocity dampner
           // Debug.Log(rb.velocity.z);
            //if we have velocity to the right
            /*
            if (rb.velocity.z > 0)
            {
                rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, rb.velocity.z - sideFriction);
            }
            if (rb.velocity.z < 0)
            {
                rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, rb.velocity.z + sideFriction);
            }
            */
            // dampen it

            //if we have velocity to the left
            //dampen it


        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("CollisionEnter");
        rb.AddRelativeForce(Vector3.left * sideJumpForce);
        if (collision.gameObject.tag =="wolf")
        {
            dead = true;
            isEscaping = false;
            Debug.Log("DEAD");
        }
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.tag == "wolf")
        {
            dead = true;
            isEscaping = false;
        }
    }

    void Update()
    {
        if(dead)
        {
            Transform[] allTransforms = gameObject.GetComponentsInChildren<Transform>();

            foreach (Transform childObjects in allTransforms)
            {
                if (gameObject.transform.IsChildOf(childObjects.transform) == false)
                    Destroy(childObjects.gameObject);
            }
        }
    }
}
