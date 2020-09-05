using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverMusic : MonoBehaviour
{
    private AudioSource music;
    // Start is called before the first frame update
    void Start()
    {
        music = gameObject.GetComponent<AudioSource>();
        music.Play();
        Invoke("Off", 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Off()
    {
        music.Stop();
    }

}
