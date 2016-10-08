using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour {

	private Rigidbody rb;

	void Awake ()
	{
		rb = GetComponent<Rigidbody> ();
	}
	
	void Update ()
	{
		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");
	
		rb.AddForce (h * 50, 0, v * 50);
	}
}
