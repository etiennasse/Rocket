using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {
    public Rigidbody RocketRigidBody;
    [SerializeField] public float ForceUpward = 20;
    [SerializeField] public float ForceSide = 20;
    // Use this for initialization
    void Start () {
        RocketRigidBody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Jump") > 0)
        {
            RocketRigidBody.AddRelativeForce(new Vector3(0, ForceUpward, 0));
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            RocketRigidBody.AddForceAtPosition(new Vector3(-ForceSide, 0, 0), new Vector3(0, 5, 0));
        } else if (Input.GetAxis("Horizontal") < 0)
        {
            RocketRigidBody.AddForceAtPosition(new Vector3(ForceSide, 0, 0), new Vector3(0, 5, 0));
        }

    }
}
