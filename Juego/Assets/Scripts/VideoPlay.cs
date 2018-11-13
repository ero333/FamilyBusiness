using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;

public class VideoPlay : MonoBehaviour {    

    public static VideoPlayer videoInicial;
    bool empezar = false;
    private string sceneName;
    public GameObject camAnimacion;
    public static bool showoOne = false;
    public GameObject dog1;
    //public GameObject dog2;

    // Use this for initialization
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;    
        videoInicial = GameObject.Find("Video Player").GetComponent<VideoPlayer>();        
        camAnimacion.SetActive(false);

        switch (sceneName) { 
            case "Credits":
                videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene - Creditos.mp4");
            break;

            case "Tutorial":
        
                videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Escena 1 - Tutorial.mp4");
                showoOne = SaltearNivel0;
                break;


            case "Level1":
        
                videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene - Nivel 1.mp4");
                showoOne = SaltearNivel1;
                break;

            case "Level2": 
        
               videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene - Nivel 2.mp4");
                showoOne = SaltearNivel2;
                break;

            case "Level3":
        
                videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene - Nivel 3.mp4");
                showoOne = SaltearNivel3;
                break;

            case "Level4":
        
               videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene - Nivel 4.mp4");
                showoOne = SaltearNivel4;
                break;
            case "Level5":
        
                videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene - Nivel 5.mp4");
                showoOne = SaltearNivel5;
                break;
            case "Level6":
        
                videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene - Nivel 6.mp4");

                showoOne = SaltearNivel6;
                break;
            case "Level7":
        
                videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene - Nivel 7.mp4");

                showoOne = SaltearNivel7; break;
            case "Level8":
        
               videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene - Nivel 8.mp4");
                showoOne = SaltearNivel8;
                break;
            case "Level9":
        
                videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene - Nivel 9.mp4");
                showoOne = SaltearNivel9;
                break;
            case "Level10":
        
              videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene - Nivel 10.mp4");
                showoOne = SaltearNivel10;
                break;
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

                    //dog2.GetComponent<AudioSource>().mute = true;
                }

                camAnimacion.SetActive(true);
                Time.timeScale = 0;
                MusicController.aus.mute = true;

                if (Input.GetKeyDown(KeyCode.Mouse0) || showoOne)
                {

                    if (!showoOne )
                    {
                        // mandar el evento de salter
                    }
                       
                    
                    videoInicial.Stop();
                    camAnimacion.SetActive(false);
                    Time.timeScale = 1;
                    MusicController.aus.mute = false;
                    this.gameObject.SetActive(false);

                    if (sceneName == "Level8")
                    {

                        //dog2.GetComponent<AudioSource>().mute = false;
                    }

                }
            }
            else
            {
                videoInicial.Stop();

                // mandar el evento de lo vio hasta el final

                switch (sceneName)
                {
                    case "Tutorial":
                        SaltearNivel0 = true;
                        break;
                    case "Level1":
                        SaltearNivel1 = true;
                        break;
                    case "Level2":
                        SaltearNivel2 = true;
                        break;
                    case "Level3":
                        SaltearNivel3 = true;
                        break;
                    case "Level4":
                        SaltearNivel4 = true;
                        break;
                    case "Level5":
                        SaltearNivel5 = true;
                        break;
                    case "Level6":
                        SaltearNivel6 = true;
                        break;
                    case "Level7":
                        SaltearNivel7 = true;
                        break;
                    case "Level8":
                        SaltearNivel8 = true;
                        break;
                    case "Level9":
                        SaltearNivel9 = true;
                        break;
                    case "Level10":
                        SaltearNivel10 = true;
                        break;
                }


                MusicController.aus.mute = false;
                if (sceneName == "Level8")
                {
                    //dog2.GetComponent<AudioSource>().mute = false;
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
