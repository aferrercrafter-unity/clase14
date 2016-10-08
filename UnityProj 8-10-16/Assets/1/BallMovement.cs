using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallMovement : MonoBehaviour {

	private Rigidbody rb;

	private float v = 0f;

	[Range(0,50)] // Atributo. Ver inspector.
	public float speed;

	void Awake ()
	{
		rb = GetComponent<Rigidbody> ();
	}

	void Update ()
	{
		v = Input.GetAxisRaw ("Vertical");
	}

	void FixedUpdate ()
	{
		rb.AddForce (Vector3.forward * v * speed);
	}
}
