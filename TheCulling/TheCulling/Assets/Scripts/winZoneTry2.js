#pragma strict

var target : Collider; //this is the variable that will hold the colliding object
private var triggered : boolean = false; //If we only want to detect the first time it's triggered

    function OnTriggerEnter(collision : Collider)
        {
            if (collision != target) //The colliding object isn't our object
            {
                return; //don't do anything if it's not our target
            }
            triggered = true;
            Debug.Log("triggered");
        }
