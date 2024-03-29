using UnityEngine;
using System.Collections;

public class RotatePlanet : MonoBehaviour {
	public float rot_speed_x=0;
	public float rot_speed_y=0;
	public float rot_speed_z=0;
	public bool local=false;
	
	// Use this for initialization
	void Start () { 
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (local) {
			transform.Rotate(Time.fixedDeltaTime*new Vector3(rot_speed_x,rot_speed_y,rot_speed_z), Space.Self);
		} else {
			transform.Rotate(Time.fixedDeltaTime*new Vector3(rot_speed_x,rot_speed_y,rot_speed_z), Space.World);
		}
	}
}
