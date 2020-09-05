using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallHandler : MonoBehaviour
{
    [SerializeField] private GameObject[] wallPrefabs;
    [SerializeField] private GameObject player;
    int currentPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame 
    void Update()
    {
        if(((int)player.transform.position.y)%4==0 && currentPos!= (int)player.transform.position.y)
        {
            currentPos = (int)player.transform.position.y;
            GameObject x = Instantiate(wallPrefabs[Random.Range(0, 2)], new Vector3(transform.position.x,gameObject.transform.GetChild(transform.childCount-1).gameObject.transform.position.y+4,0), Quaternion.identity);
            x.transform.parent = gameObject.transform;
            Destroy(gameObject.transform.GetChild(0).gameObject);
        }
    }
}
