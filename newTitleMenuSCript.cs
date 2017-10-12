using UnityEngine;
using System.Collections;

public class newTitleMenuSCript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Camera.main.transform.position = Vector3 (0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			transform.position = Vector3.Lerp (this.transform.position, new Vector3 (3.91f, 2.4f, -13.23f),.2f);
			//Camera.main.transform.position = Vector3 (3.91, 2.4, -13.23);
		}
	}
}
