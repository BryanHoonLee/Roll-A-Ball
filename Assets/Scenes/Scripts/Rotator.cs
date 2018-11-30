using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    // not dealing with forces so can just use update
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(15,30,45) * Time.deltaTime);
	}
}
