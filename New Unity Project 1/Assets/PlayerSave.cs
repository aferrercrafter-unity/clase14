using UnityEngine;
using System.Collections;

public class PlayerSave : MonoBehaviour {

    Progress save;

	// Use this for initialization
	void Awake () {

        save = GameObject.FindGameObjectWithTag("Progress").GetComponent<Progress>();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Checkpoint"))
        {
            print("Player ask for save");
            save.save(this.gameObject.transform.position);
        }
        
    }
}
