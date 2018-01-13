using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMovement : MonoBehaviour
{

	public float CookieSpeed;

	
	
	// Update is called once per frame
	void Update () {
		transform.position += Vector3.back * Time.deltaTime * CookieSpeed;
	}
}
