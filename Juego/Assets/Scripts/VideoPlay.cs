using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoPlay : MonoBehaviour {    

    public static VideoPlayer videoInicial;
    bool empezar = false;
    

    // Use this for initialization
    void Start()
    {
        videoInicial = GameObject.Find("Video Player").GetComponent<VideoPlayer>();
        videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Escena 1 - Tutorial.mp4");
        videoInicial.Play();
        
        
    }


    // Update is called once per frame
    void Update()
    {
      
        
        if (videoInicial.isPlaying == true)
        {
            Time.timeScale = 0;
            MusicController.aus.mute = true;

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                videoInicial.Stop();
                Time.timeScale = 1;
                MusicController.aus.mute = false;                
            }
        }
        else
        {
            videoInicial.Stop();            
            MusicController.aus.mute = false;

            if (empezar == false)
            {
                
                Time.timeScale = 1;                
                empezar = true;

            }
            
                     
        }
        
      
        
    }
   
}
