using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;

public class CutsceneDisplay : MonoBehaviour {
	public CutsceneContainer[] cutsceneBits;
	CutsceneContainer activeCutscene;
	public Texture2D activeFace;
	int faceAnimCounter = 0;
	int cutsceneCounter = 0;
    int conten1, conten2;
    float faceAnimateTimer = 0.15f;//,faceReturn=0.15f;
	public Texture2D bg;
	public GUIStyle text;
    public SpriteRenderer en1, en2;
    float originalWidth = 1920.0f; //turn these to floats to fix placement issue
	float originalHeight = 1080.0f;
	Vector3 scale;
    bool display = false;
	public static bool anyCutsceneDisplaying = false;

	// Use this for initialization
	void Start () {
     
    }
	
	// Update is called once per frame
	void Update () {
		inputControl ();
		animateFace ();

	}

	void animateFace()
	{
		faceAnimateTimer -= Time.deltaTime;
		activeFace = activeCutscene.faces [faceAnimCounter];
		if (faceAnimateTimer <= 0) {
			if (faceAnimCounter < activeCutscene.faces.Length - 1) {
				faceAnimCounter++;
			} else {
				faceAnimCounter = 0;
			}
		}
	}

	void inputControl()
	{
		activeCutscene = cutsceneBits [cutsceneCounter];
		if (Input.GetKeyDown (KeyCode.Mouse0) && display == true)
        {
			if (cutsceneCounter < cutsceneBits.Length-1)
            {
				cutsceneCounter++;
			}

            else
            {
                anyCutsceneDisplaying = false;
                Time.timeScale = 1;
				Analytics.CustomEvent("VerTutorial", new Dictionary<string, object>
				{
                    { "paso", activeCutscene.Paso },
                    { "tiempo", Time.timeSinceLevelLoad }
                }
				);
				print ("paso: "+activeCutscene.Paso + " tiempo en que se realizo el paso: " + Time.timeSinceLevelLoad);
                Destroy(this.gameObject);
            }

                    
            
        }
    }

    //el siguiente collider hay que moverlo en la escena

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
			display = true;
			Time.timeScale = 0;
			anyCutsceneDisplaying = true;
			//activeCutscene = cutsceneBits [cutsceneCounter];
		}
	}

	void OnGUI()
	{
		GUI.depth = 0;
		scale.x = Screen.width/originalWidth;
		scale.y = Screen.height/originalHeight;
		scale.z =1;
		var svMat = GUI.matrix;
		GUI.matrix = Matrix4x4.TRS(Vector3.zero,Quaternion.identity,scale);
		if (display == true) {
			GUI.DrawTexture (new Rect (0, 0, originalWidth, originalHeight), bg); // agrega el fondo negro
			GUI.DrawTexture (new Rect (originalWidth - 550, originalHeight / 2-400, 700, 600), activeFace); // Activa la cara de la persona hablando
			GUI.Box (new Rect (originalWidth / 2-500, originalHeight - 150, 1000, 100), activeCutscene.Text,text);
			//print ("paso: "+activeCutscene.Paso);
		}
		GUI.matrix = svMat;
	}
}
