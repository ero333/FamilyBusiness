using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoPlay : MonoBehaviour {
    public VideoClip videoClip;    
    public int cont = 0;

    // Use this for initialization
    void Start()
    {
        var videoPlayer = gameObject.AddComponent<VideoPlayer>();
        videoPlayer.clip = videoClip;       
        videoPlayer.isLooping = true;            
        
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

        if ((Input.GetKeyDown(KeyCode.Return)) || (Input.GetKeyDown(KeyCode.Mouse0)))
        {
            SceneManager.LoadScene("Tutorial");
        }

    }
   
}
