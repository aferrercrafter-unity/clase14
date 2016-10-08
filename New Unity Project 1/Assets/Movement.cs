using UnityEngine;

public class Movement : MonoBehaviour {

    float movx;
    float movz;
    Rigidbody rb;
    public float speed;

	// Use this for initialization
	void Awake () {
        rb = GetComponent<Rigidbody>();
	}
    void FixedUpdate()
    {
        movx = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        movz = Input.GetAxis("Vertical") * speed * Time.deltaTime;
    }
	// Update is called once per frame
	void Update () {
        rb.AddForce(Vector3.back * movx);
        rb.AddForce(Vector3.right * movz);
	}
}
