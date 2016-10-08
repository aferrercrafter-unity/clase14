using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

    public GameObject player;
    public Vector3 pos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame


	void Update () {

        this.gameObject.transform.position = player.transform.position;

	}
}
