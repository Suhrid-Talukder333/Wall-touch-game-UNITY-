using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] internal float movespeed = 0f;
    [SerializeField] GameObject timerTxtParent;
    [SerializeField] ParticleSystem playerBurst;
    [SerializeField] AudioClip[] sounds;
    [SerializeField] Text scoreTxt;

    private AudioSource effects;
    internal static bool left=false;
    internal static bool right = false;
    private bool startTimer = true;
    private float timer = 5f;
    internal int score = 0;
    private bool scoreIncrease = true;
    // Start is called before the first frame update
    void Start()
    {
       effects = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = score.ToString();
        transform.Translate(Vector3.up * movespeed * Time.deltaTime);
        if (left && transform.position.x >= -1.5f)
        {
            transform.Translate(Vector3.left * movespeed * Time.deltaTime);
        }
        else if(right && transform.position.x <= 1.5f)
        {
            transform.Translate(Vector3.right * movespeed * Time.deltaTime);
        }
        if(startTimer)
        {
            timer -= Time.deltaTime;
            timerTxtParent.transform.GetChild(0).gameObject.GetComponent<Text>().text = ((int)timer).ToString();
        }
        if(timer<=0)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            movespeed = 0;
            startTimer = false;
            playerBurst.Play();
            playerBurst.SetParticles(null);
            effects.clip = sounds[1];
            effects.Play();
            Invoke("GameOver", 1f);
        }
        Invoke("Score", 1.5f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Enemy")
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            movespeed = 0;
            startTimer = false;
            playerBurst.Play();
            playerBurst.SetParticles(null);
            effects.clip = sounds[0];
            effects.Play();
            effects.clip = sounds[1];
            effects.Play();
            Invoke("GameOver", 1f);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag =="Wall")
        {
            scoreIncrease = false;
            timer = 5f;
            timerTxtParent.SetActive(true);
        }
    }
    private void GameOver()
    {
        SceneManager.LoadScene(2);
    }
    private void Score()
    {
        if(timer<=0 && scoreIncrease)
        {
            score = score + 0;
        }
        else
        {
            score++;
        }
        PlayerPrefs.SetInt("score", score);
    }
}
