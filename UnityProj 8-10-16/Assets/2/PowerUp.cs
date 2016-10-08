using UnityEngine;

public class PowerUp : MonoBehaviour
{
	void Update ()
	{
		transform.Rotate (Vector3.up * Time.deltaTime * 250);
	}
}
