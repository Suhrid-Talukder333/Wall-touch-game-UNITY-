using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObstacles : MonoBehaviour
{
    [SerializeField] private PlayerController pc;
    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private Transform[] spawnPoints;

    private float timer = 4f;
    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(3,5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * pc.movespeed);
        if(timer <= 0)
        {
            Instantiate(obstaclePrefab, spawnPoints[Random.Range(0, spawnPoints.Length-1)].position, Quaternion.identity);
            timer = Random.Range(3, 5);
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}
