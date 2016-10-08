using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour {

    Manager man;

	// Use this for initialization
	void Awake () {
	    
        man = GameObject.FindGameObjectWithTag("Manager").GetComponent<Manager>();

	}

    void OnTriggerEnter(Collider col)
    {
        man.setScore();
        Destroy(this.gameObject);
    }
}
