using UnityEngine;
using System.Collections;

public class Car : MonoBehaviour {
	private Rigidbody carRigid;
	public int speed;
	public int rotateSpeed;

	// Use this for initialization
	void Start () {
		carRigid = GetComponent<Rigidbody> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void FixedUpdate(){
		if (Input.GetButton("Forward")){
			carRigid.AddForce (transform.right * -speed * Time.deltaTime);
}
		if (Input.GetButton("Reverse")){
			carRigid.AddForce (transform.right * speed * Time.deltaTime);
		}

		if (Input.GetButton("Left")){
			transform.Rotate (0, -rotateSpeed, 0);
		}

		if (Input.GetButton("Right")){
			transform.Rotate (0, rotateSpeed, 0);
		}
		if (Input.GetButton("Reset")){
			Application.LoadLevel ("Menu");
		}
		if (Input.GetButton("Recover")){
			Application.LoadLevel ("Scene2");
		}
		if (Input.GetButton("Upfly")){
			transform.Rotate (0, 0, rotateSpeed);
		}	
		if (Input.GetButton("Downfly")){
			transform.Rotate (0, 0, -rotateSpeed);
		}

	}
}
