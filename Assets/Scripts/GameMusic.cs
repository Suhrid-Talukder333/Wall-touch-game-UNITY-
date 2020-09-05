using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMusic : MonoBehaviour
{
    private AudioSource music;
    // Start is called before the first frame update
    void Start()
    {
        music = gameObject.GetComponent<AudioSource>();
        music.Play();
    }

    // Update is called once per frame
    void Update()
    {
  
        
    }
}
