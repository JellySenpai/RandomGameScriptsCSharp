using UnityEngine;
using System.Collections;
using System;

public class throwScript : MonoBehaviour {
    public float pickUpDist = 1f;

    private Transform carriedObject = null;
    private int pickupLayer = 1 << LayerMask.NameToLayer("Pickup");
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("pickup"))
        {
            if (carriedObject != null)
            { Drop(); }
        }
	}

    private void Drop()
    {
        throw new NotImplementedException();
    }
}
