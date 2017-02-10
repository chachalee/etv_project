using UnityEngine;
using System.Collections;

public class elevatorLift : MonoBehaviour {

	private bool pressedButton = false;
	private bool isElevatorUp = false;

	GameObject target;

	void OnMouseOver()
	{
		pressedButton = true;
	}

	void OnMouseExit()
	{
		pressedButton = false;
	}

	void OnMouseDown()
	{
		if(isElevatorUp == false)
		{
			target = GameObject.Find("Elevator");
			target.GetComponent<Animation>().Play("1");
			Debug.Log ("Up");
			isElevatorUp = true;
		}
		else
		{
			target = GameObject.Find("Elevator");
			target.GetComponent<Animation>().Play("2");
			Debug.Log ("Down");
			isElevatorUp = false;
		}
	}
 
}