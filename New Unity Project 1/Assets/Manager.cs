using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Manager : MonoBehaviour {

    public GameObject player;
    public GameObject powerUp;    

    float time = 0;
    bool score_up = false;

    public Text score_txt;
    public Text txt;

    Progress save;
   
    int score = 0;

	// Use this for initialization
	void Awake () {

        save = GameObject.FindGameObjectWithTag("Progress").GetComponent<Progress>();
        
        float posx = PlayerPrefs.GetFloat("posX", -48);
        float posy = PlayerPrefs.GetFloat("posY", 1);
        float posz = PlayerPrefs.GetFloat("posZ", 0);
        int score = PlayerPrefs.GetInt("score", 0);

        player.transform.position = new Vector3(posx, posy, posz);
        score_txt.text = "Score: " + score;        
        InvokeRepeating("Spawn", 1, 1);
	}

    void Spawn()
    {
        float posx = Random.Range(-50, 50);
        float posz = Random.Range(-2, 2);
        Instantiate(powerUp, new Vector3(posx, 1, posz), Quaternion.identity);
    }

    void Update()
    {

        if (score_up)
        {
            time += Time.deltaTime;
            txt.transform.Translate(Vector3.up * 1 * Time.deltaTime);
            if (time > 2)
            {
                score_up = false;
                time = 0;
                txt.text = "";
            }

        }



    }

    public void setScore()
    {
        score++;
        float posX = txt.transform.position.x;
        float posZ = txt.transform.position.z;
        txt.transform.position = new Vector3(posX, 1.0f, posZ);
        txt.text = "Score +1";
        score_up = true;
        score_txt.text = "Score: " + score;
        save.setScore();

    }
}
