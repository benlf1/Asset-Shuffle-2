using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int score = 0;
    int scoreInterval = 1;
    public float interval = 3;
    float nextTime = 0;
    float nextScoreTime = 0;
    public GameObject enemy;

    public float enemySpeed;
    public Text scoreText;

    public GameObject player;

    public Camera cam;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextScoreTime)
        {
            score += 1;
            scoreText.text = "Time Alive: " + score;
            nextScoreTime += scoreInterval;
            if(interval > 0.3f) {
                interval -= 0.01f;
            }
        }
        if (Time.time >= nextTime)
        {
            // get quadrant 1 lengths
            float lenY = cam.orthographicSize;
            float lenX = lenY * cam.aspect;
            
            // randomly generate a pos on one axis
            bool axisY = Random.Range(0, 2) != 0;
            
            float posX = lenX;
            float posY = lenY;
            
            if(axisY) {
                posY = Random.Range(0, lenY);
            } else {
                posX = Random.Range(0, lenX);
            }

            int[] signs = {-1, 1};

            // randomly flip signs to use different quadrants
            Vector3 pos = new Vector3(posX * signs[Random.Range(0, 2)], posY * signs[Random.Range(0, 2)], 0);
            GameObject obj = Instantiate(enemy, pos, Quaternion.identity);
            EnemyController ec = obj.GetComponent<EnemyController>();
            ec.moveSpeed = Random.Range(0, enemySpeed);
            ec.player = player;
            nextTime += Random.Range(0, interval);
        }
    }
}
