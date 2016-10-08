using UnityEngine;

public class Cartel : MonoBehaviour {

	public Transform bola;

	void Update () {

		transform.position = bola.position + Vector3.up;
	
		transform.LookAt (transform.position - Camera.main.transform.position);
	}
}
