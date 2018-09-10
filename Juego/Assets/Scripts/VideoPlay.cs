using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoPlay : MonoBehaviour {    
    public VideoPlayer videoInicial;
    public static int cont = 0;

    // Use this for initialization
    void Start()
    {
        var videoPlayer = gameObject.AddComponent<VideoPlayer>();
        videoInicial.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene 1.mp4");
        videoInicial.Play();

    }


    // Update is called once per frame
    void Update()
    {
        
        


        if (cont <= 2100)
        {
            cont += 1;
        }
       
        else 
        {

            SceneManager.LoadScene("Tutorial");
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            SceneManager.LoadScene("Tutorial");
        }

    }
   
}
