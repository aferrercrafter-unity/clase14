using UnityEngine;

public class SaveLoadCheckpoint : MonoBehaviour {

	void Start ()
	{
		if (PlayerPrefs.HasKey ("posX"))
		{
			float x = PlayerPrefs.GetFloat ("posX");
			float y = PlayerPrefs.GetFloat ("posY");
			float z = PlayerPrefs.GetFloat ("posZ");

			transform.position = new Vector3 (x, y, z);
		}
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.CompareTag ("Checkpoint"))
		{
			PlayerPrefs.SetFloat ("posX", other.transform.position.x);
			PlayerPrefs.SetFloat ("posY", transform.position.y);
			PlayerPrefs.SetFloat ("posZ", other.transform.position.z);
		}
	}
}
