using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.UIElements;

public class spawnTesting : MonoBehaviour
{
    public GameObject[] balls;
    public float spawndistance = 1.0f;
    int index = 0;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    void spawnBalls()
    {
        Instantiate(balls[index], new Vector2 (transform.position.x + spawndistance , transform.position.y), Quaternion.identity, transform);
       
        index++;
    }
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1)
        {
            index = Random.Range(0, balls.Length);
            spawnBalls();
            timer = 0;
        }
    }
}
