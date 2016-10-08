using UnityEngine;
using System.Collections;

public class Progress : MonoBehaviour {

    float posx;
    float posy;
    float posz;
    int waypoint;
    int score = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void save(Vector3 pos)
    {
        posx = pos.x;
        posy = pos.y;
        posz = pos.z;
        PlayerPrefs.SetFloat("posX", posx);
        PlayerPrefs.SetFloat("posY", posy);
        PlayerPrefs.SetFloat("posZ", posz);
        PlayerPrefs.SetInt("score", score);
    }

    public void setScore()
    {
        score++;
    }
}
