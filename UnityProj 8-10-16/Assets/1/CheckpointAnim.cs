using UnityEngine;
using System.Collections;

public class CheckpointAnim : MonoBehaviour {

	private ParticleSystem ps;

	void Awake ()
	{
		ps = GetComponentInChildren<ParticleSystem> ();
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.CompareTag ("Player"))
		{
			ps.Play ();
		}
	}
}
