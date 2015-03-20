using UnityEngine;
using System.Collections;

public class CPRanimation : MonoBehaviour {

	//animator
	Animator anim;
	
	//variables for animation -DLO
	public bool isTouched = false;
	public bool isReleased = false;
	
	// Use this for initialization
	void Start () {
		//get animation controller and assign to anim -DLO
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		anim.SetBool ("touched", isTouched);
		anim.SetBool ("released", isReleased);
		
		if (Input.GetMouseButtonDown (0)) {
			//play animation -DLO
			isTouched = true;
			isReleased = true;
		}
		
		if (Input.GetMouseButtonUp (0)) {
			//stop animation from looping -DLO
			isTouched = false;
		}
	}
}