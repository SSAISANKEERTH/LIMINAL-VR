using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public AudioSource MusicSource;
    public AudioClip MusicClip;
     void Start()
    {
        MusicSource.clip = MusicClip;   
    }
     void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            MusicSource.Play();
            

        }
    }
    public void PlayGame ()
    {
        SceneManager.LoadScene("Game");

    }
}
