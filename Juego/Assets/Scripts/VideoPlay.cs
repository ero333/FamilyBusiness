using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoPlay : MonoBehaviour {    

    public static VideoPlayer videoInicial;
    bool empezar = false;
    private string sceneName;


    // Use this for initialization
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;    
        videoInicial = GameObject.Find("Video Player").GetComponent<VideoPlayer>();
        if (sceneName == "Tutorial")
        {
            videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Escena 1 - Tutorial.mp4");
        }

        else if (sceneName == "Level1")
        {
            videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene - Nivel 1.mp4");
        }
        
        else if (sceneName == "Level2")
        {
            videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene - Nivel 2.mp4");
        }

        
        
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
