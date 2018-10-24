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
    public static bool showoOne = true;
    public GameObject dog1;
    public GameObject dog2;

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

        else if (sceneName == "Level1" && showoOne == true)
        {
            videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene - Nivel 1.mp4");
        }
        
        else if (sceneName == "Level2" && showoOne == true)
        {
            videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene - Nivel 2.mp4");
        }

        else if (sceneName == "Level3" && showoOne == true)
        {
            videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene - Nivel 3.mp4");
        }

        else if (sceneName == "Level4" && showoOne == true)
        {
            videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene - Nivel 4.mp4");
        }
        else if (sceneName == "Level5" && showoOne == true)
        {
            videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene - Nivel 5.mp4");
        }
        else if (sceneName == "Level6" && showoOne == true)
        {
            videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene - Nivel 6.mp4");
        }
        else if (sceneName == "Level7" && showoOne == true)
        {
            videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene - Nivel 7.mp4");
        }
        else if (sceneName == "Level8" && showoOne == true)
        {
            videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene - Nivel 8.mp4");
        }
        else if (sceneName == "Level9" && showoOne == true)
        {
            videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene - Nivel 9.mp4");
        }
        else if (sceneName == "Level10" && showoOne == true)
        {
            videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene - Nivel 10.mp4");
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
                if (sceneName == "Level8")
                {

                    dog1.GetComponent<AudioSource>().mute = true;
                    dog2.GetComponent<AudioSource>().mute = true;
                }

            camAnimacion.SetActive(true);
            Time.timeScale = 0;
            MusicController.aus.mute = true;


                if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                videoInicial.Stop();
                camAnimacion.SetActive(false);
                Time.timeScale = 1;
                MusicController.aus.mute = false;
                    this.gameObject.SetActive(false);

                    if (sceneName == "Level8")
                    {

                        dog1.GetComponent<AudioSource>().mute = false;
                        dog2.GetComponent<AudioSource>().mute = false;
                    }

                }
        }
        else
        {
            videoInicial.Stop();

                MusicController.aus.mute = false;
                if (sceneName == "Level8")
                {

                    dog1.GetComponent<AudioSource>().mute = false;
                    dog2.GetComponent<AudioSource>().mute = false;
                }

                if (empezar == false)
            {
                camAnimacion.SetActive(false);
                Time.timeScale = 1;
                this.gameObject.SetActive(false);
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
