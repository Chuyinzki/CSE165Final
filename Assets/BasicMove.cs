using UnityEngine;
using System.Collections;

public class BasicMove : MonoBehaviour {

	int speedMov = 3;
	int speedRotate = 60;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		///////////////////////ROTATION//////////////////////////
		
		if (Input.GetKey ("j")) {
			print ("j key is held down");
			transform.Rotate(0, Time.deltaTime* -speedRotate, 0);
			//transform.localEulerAngles.y += speedRotate; //turn right
		}
		
		if (Input.GetKey ("l")) {
			print ("l key is held down");
			transform.Rotate(0, Time.deltaTime* speedRotate, 0);
			//transform.localEulerAngles.y -= speedRotate; //turn right
		}

		///////////////////////MOVEMENT//////////////////////////
		if (Input.GetKey ("w")) {
			print ("up arrow key is held down");
			transform.Translate (Vector3.forward * Time.deltaTime * speedMov);
		}
		
		if (Input.GetKey ("s")) {
			print ("down arrow key is held down");
			transform.Translate (Vector3.back * Time.deltaTime * speedMov);
		}

		if (Input.GetKey ("a")) {
			print ("down arrow key is held down");
			transform.Translate (Vector3.left * Time.deltaTime * speedMov);
		}

		if (Input.GetKey ("d")) {
			print ("down arrow key is held down");
			transform.Translate (Vector3.right * Time.deltaTime * speedMov);
		}


	}
}
