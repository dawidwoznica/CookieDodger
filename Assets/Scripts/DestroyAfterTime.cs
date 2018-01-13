using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
	public float TimeBeforeDestroy;


	void Start () {
		Destroy(gameObject, TimeBeforeDestroy);
	}
}
