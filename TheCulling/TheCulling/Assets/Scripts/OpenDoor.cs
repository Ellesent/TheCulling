using UnityEngine;
using System.Collections;

public class OpenDoor : MonoBehaviour 
{
	/// <summary>
	/// Tracks if the player is near to display message.
	/// </summary>
	bool playerNear;
	/// <summary>
	/// The parent's rigidbody.
	/// </summary>
	Rigidbody rb;
	/// <summary>
	/// The constant force that pushes the door.
	/// </summary>
	ConstantForce cf;
	/// <summary>
	/// The name of the player object.
	/// </summary>
	public GameObject player;
	/// <summary>
	/// The name of the button that pushes the door.
	/// </summary>
	public string buttonName;
	/// <summary>
	/// The display message when close to the door.
	/// </summary>
	public string message;
	/// <summary>
	/// The color of the text.
	/// </summary>
	public Color textColor;
	/// <summary>
	/// The direction and force to push the door.
	/// </summary>
	public float pushForce;
	/// <summary>
	/// The duration of the push.
	/// </summary>
	public float pushDuration = 0.5f;

	/// <summary>
	/// Raises the trigger enter event.
	/// Dectects if player is near to display message.
	/// </summary>
	/// <param name="other">Other.</param>
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject == player) 
		{
			playerNear = true;
		}
	}

	/// <summary>
	/// Raises the trigger exit event.
	/// Dectects if player is far to remove message.
	/// </summary>
	/// <param name="other">Other.</param>
	void OnTriggerExit (Collider other)
	{
		if (other.gameObject == player) 
		{
			playerNear = false;
		}
	}

	/// <summary>
	/// Start this instance.
	/// </summary>
	void Start () 
	{
		rb = GetComponentInParent<Rigidbody>();
		playerNear = false;

		// Propogate the settings if this is the parent door
		if (transform.childCount > 0) 
		{
			// Move most settings on this component to children so we only make change in 1 place
			OpenDoor[] ods = GetComponentsInChildren<OpenDoor> (true);
			foreach (OpenDoor od in ods) 
			{
				od.player = player;
				od.buttonName = buttonName;
				od.message = message;
				od.textColor = textColor;
				od.pushDuration = pushDuration;
				// Don't copy pushForce: that's unique to the children
			}
			// Destroy itself, since we don't want this on the parent durring the actual game
			Destroy (this);
		}
	}

	/// <summary>
	/// Raises the GU event.
	/// </summary>
	void OnGUI () 
	{
		// Display message explaining how to push door when player is near
		if (playerNear) 
		{
			GUI.contentColor = textColor;
			GUI.Label (new Rect (0, Screen.height - 25, 150, 25), message);
		}
	}

	/// <summary>
	/// Update this instance.
	/// </summary>
	void Update ()
	{
		// Only push door when player is near
		if (playerNear) 
		{
			// Push door on button press
			if (Input.GetButton (buttonName)) 
			{
				// Remove lock on door
				rb.constraints = RigidbodyConstraints.None;
				// Only push door if no constant force already present
				ConstantForce cf = GetComponentInParent<ConstantForce>();
				if (cf == null) 
				{
					// Push the door with a constant force
					cf = transform.parent.gameObject.AddComponent<ConstantForce> ();
					cf.relativeForce = new Vector3 (0, 0, pushForce);
					// Stop pushing after a time
					Invoke ("StopPush", pushDuration);
				}
			}
		}
	}

	/// <summary>
	/// Stops the push.
	/// </summary>
	void StopPush()
	{
		// Make sure we have a force before we try to remove it
		ConstantForce cf = GetComponentInParent<ConstantForce>();
		if (cf != null)
			Destroy (cf);
	}
}
