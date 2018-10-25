using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoMirtha : MonoBehaviour {

    public GameObject camara;
    public GameObject videoplayer;
    public VideoPlayer videoIntermedio;
    public GameObject vidaBoss;

    // Use this for initialization
    void Start () {
        camara.SetActive(false);
        videoplayer.SetActive(false);
        vidaBoss.SetActive(false);


    }
	
	// Update is called once per frame
	void Update () {		

        if (videoIntermedio.isPlaying == true)
        {
            Time.timeScale = 0;
            MusicController.aus.mute = true;

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Time.timeScale = 1;
                MusicController.aus.mute = false;
                camara.SetActive(false);
                videoplayer.SetActive(false);
            }

        }

        else
        {
            Time.timeScale = 1;
            MusicController.aus.mute = false;
            camara.SetActive(false);
            videoplayer.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            videoplayer.SetActive(true);
            videoIntermedio.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Cutscene Intermedio - Nivel 10.mp4");
            camara.SetActive(true);
            videoIntermedio.Play();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            vidaBoss.SetActive(true);
        }
    }
}
