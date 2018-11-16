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
                showoOne = GameManager.SaltearNivel0;
                break;


            case "Level1":
        
                videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene - Nivel 1.mp4");
                showoOne = GameManager.SaltearNivel1;
                break;

            case "Level2": 
        
               videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene - Nivel 2.mp4");
                showoOne = GameManager.SaltearNivel2;
                break;

            case "Level3":
        
                videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene - Nivel 3.mp4");
                showoOne = GameManager.SaltearNivel3;
                break;

            case "Level4":
        
               videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene - Nivel 4.mp4");
                showoOne = GameManager.SaltearNivel4;
                break;
            case "Level5":
        
                videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene - Nivel 5.mp4");
                showoOne = GameManager.SaltearNivel5;
                break;
            case "Level6":
        
                videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene - Nivel 6.mp4");

                showoOne = GameManager.SaltearNivel6;
                break;
            case "Level7":
        
                videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene - Nivel 7.mp4");

                showoOne = GameManager.SaltearNivel7; break;
            case "Level8":
        
               videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene - Nivel 8.mp4");
                showoOne = GameManager.SaltearNivel8;
                break;
            case "Level9":
        
                videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene - Nivel 9.mp4");
                showoOne = GameManager.SaltearNivel9;
                break;
            case "Level10":
        
              videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene - Nivel 10.mp4");
                showoOne = GameManager.SaltearNivel10;
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
                    
                    dog1.GetComponent<AudioSource>().mute = true;
                }

                camAnimacion.SetActive(true);
                Time.timeScale = 0;
                MusicController.aus.mute = true;

                if (Input.GetKeyDown(KeyCode.Mouse0) || showoOne)
                {
					
                    if (!showoOne )
                    {
                        // mandar el evento de salter

						switch (sceneName)
						{
						case "Tutorial":
							Analytics.CustomEvent("SaltarCutScene", new Dictionary<string, object> {{ "nivel", 0 }});
							break;
						case "Level1":
							Analytics.CustomEvent("SaltarCutScene", new Dictionary<string, object> {{ "nivel", 1 }});
							break;
						case "Level2":
							Analytics.CustomEvent("SaltarCutScene", new Dictionary<string, object> {{ "nivel", 2 }});
							break;
						case "Level3":
							Analytics.CustomEvent("SaltarCutScene", new Dictionary<string, object> {{ "nivel", 3 }});
							break;
						case "Level4":
							Analytics.CustomEvent("SaltarCutScene", new Dictionary<string, object> {{ "nivel", 4 }});
							break;
						case "Level5":
							Analytics.CustomEvent("SaltarCutScene", new Dictionary<string, object> {{ "nivel", 5 }});
							break;
						case "Level6":
							Analytics.CustomEvent("SaltarCutScene", new Dictionary<string, object> {{ "nivel", 6 }});
							break;
						case "Level7":
							Analytics.CustomEvent("SaltarCutScene", new Dictionary<string, object> {{ "nivel", 7 }});
							break;
						case "Level8":
							Analytics.CustomEvent("SaltarCutScene", new Dictionary<string, object> {{ "nivel", 8 }});
							break;
						case "Level9":
							Analytics.CustomEvent("SaltarCutScene", new Dictionary<string, object> {{ "nivel", 9 }});
							break;
						case "Level10":
							Analytics.CustomEvent("SaltarCutScene", new Dictionary<string, object> {{ "nivel", 10 }});
							break;
						}
                    }
                       
                    
                    videoInicial.Stop();
                    camAnimacion.SetActive(false);
                    Time.timeScale = 1;
                    MusicController.aus.mute = false;
                    this.gameObject.SetActive(false);

                    if (sceneName == "Level8")
                    {

                        dog1.GetComponent<AudioSource>().mute = false;
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
                        GameManager.SaltearNivel0 = true;
						Analytics.CustomEvent("VerCutScene", new Dictionary<string, object> {{ "nivel", 0 }});
                        break;
                    case "Level1":
                        GameManager.SaltearNivel1 = true;
						Analytics.CustomEvent("VerCutScene", new Dictionary<string, object> {{ "nivel", 1 }});
						break;
                    case "Level2":
                        GameManager.SaltearNivel2 = true;
						Analytics.CustomEvent("VerCutScene", new Dictionary<string, object> {{ "nivel", 2 }});
                        break;
                    case "Level3":
                        GameManager.SaltearNivel3 = true;
						Analytics.CustomEvent("VerCutScene", new Dictionary<string, object> {{ "nivel", 3 }});
                        break;
                    case "Level4":
                        GameManager.SaltearNivel4 = true;
						Analytics.CustomEvent("VerCutScene", new Dictionary<string, object> {{ "nivel", 4 }});
                        break;
                    case "Level5":
                        GameManager.SaltearNivel5 = true;
						Analytics.CustomEvent("VerCutScene", new Dictionary<string, object> {{ "nivel", 5 }});
                        break;
                    case "Level6":
                        GameManager.SaltearNivel6 = true;
						Analytics.CustomEvent("VerCutScene", new Dictionary<string, object> {{ "nivel", 6 }});
                        break;
                    case "Level7":
                        GameManager.SaltearNivel7 = true;
						Analytics.CustomEvent("VerCutScene", new Dictionary<string, object> {{ "nivel", 7 }});
                        break;
                    case "Level8":
                        GameManager.SaltearNivel8 = true;
						Analytics.CustomEvent("VerCutScene", new Dictionary<string, object> {{ "nivel", 8 }});
                        break;
                    case "Level9":
                        GameManager.SaltearNivel9 = true;
						Analytics.CustomEvent("VerCutScene", new Dictionary<string, object> {{ "nivel", 9 }});
						break;
                    case "Level10":
                        GameManager.SaltearNivel10 = true;
						Analytics.CustomEvent("VerCutScene", new Dictionary<string, object> {{ "nivel", 19 }});
                        break;
                }


                MusicController.aus.mute = false;
                if (sceneName == "Level8")
                {
                    dog1.GetComponent<AudioSource>().mute = false;
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
