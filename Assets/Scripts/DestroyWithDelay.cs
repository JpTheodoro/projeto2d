using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWithDelay : MonoBehaviour {

	public float delay = 3f;

	void start () {
		Destroy(gameObject, delay);
	}
}
