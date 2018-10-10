using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoPlay : MonoBehaviour {    

    public static VideoPlayer videoInicial;
    bool empezar = false;
    private string sceneName;
    public GameObject camAnimacion;

    // Use this for initialization
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;    
        videoInicial = GameObject.Find("Video Player").GetComponent<VideoPlayer>();        
        camAnimacion.SetActive(false);

        if (sceneName == "Credits")
        {
            videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene - Creditos.mp4");
        }
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

        else if (sceneName == "Level3")
        {
            videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene - Nivel 3.mp4");
        }

        else if (sceneName == "Level4")
        {
            videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene - Nivel 4.mp4");
        }
                
        videoInicial.Play();        
        
    }


    // Update is called once per frame
    void Update()
    {
      
        if (sceneName != "Credits")
        {

        
        if (videoInicial.isPlaying == true)
        {
            camAnimacion.SetActive(true);
            Time.timeScale = 0;
            MusicController.aus.mute = true;

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                videoInicial.Stop();
                camAnimacion.SetActive(false);
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
                camAnimacion.SetActive(false);
                Time.timeScale = 1;                
                empezar = true;

            }
            
                     
        }

        }

        if (sceneName == "Credits")
        {
            if (videoInicial.isPlaying == true)
            {
                camAnimacion.SetActive(true);
                
            }

            else
            {
                SceneManager.LoadScene("Menu");
            }
        }


    }
   
}
