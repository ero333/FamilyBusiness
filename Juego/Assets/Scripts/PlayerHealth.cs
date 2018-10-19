using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;

public class PlayerHealth : MonoBehaviour {
	public static bool dead=false;
    private string sceneName;
    float originalWidth = 1920.0f; //turn these to floats to fix placement issue
	float originalHeight = 1080.0f;
	Vector3 scale;
	public GUIStyle text;
	public Texture2D bg;
	public Sprite deadSpr;
    private bool flagdead = false;
    

	void awake()
	{
        
    }

	// Use this for initialization
	void Start () {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;        
    }
	
	// Update is called once per frame
	void Update () {

        if (dead == true) {
            killPlayer();                      

            if (sceneName == "Level1" && flagdead == false)
            {
                GameManager.muertes1 += 1;
                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "nivel", 1 }   }
                );
                
                flagdead = true;
                
            }
            else if (sceneName == "Level2" && flagdead == false)
            {
                GameManager.muertes2 += 1;

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "nivel", 2 }   }
                );
                flagdead = true;
            }
            else if (sceneName == "Level3" && flagdead == false)
            {
                GameManager.muertes3 += 1;

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "nivel", 3 }   }
                );
                flagdead = true;
            }
            else if (sceneName == "Level4" && flagdead == false)
            {
                GameManager.muertes4 += 1;

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "nivel", 4 }   }
                );
                flagdead = true;
            }
            else if (sceneName == "Level5" && flagdead == false)
            {
                GameManager.muertes5 += 5;

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "nivel", 5 }   }
                );
                flagdead = true;
            }
            else if (sceneName == "Level6" && flagdead == false)
            {
                GameManager.muertes6 += 1;

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "nivel", 6 }   }
                );
                flagdead = true;
            }
            else if (sceneName == "Level7" && flagdead == false)
            {
                GameManager.muertes7 += 1;

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "nivel", 7 }   }
                );
                flagdead = true;
            }
            else if (sceneName == "Level8" && flagdead == false)
            {
                GameManager.muertes8 += 1;

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "nivel", 8 }   }
                );
                flagdead = true;
            }
            else if (sceneName == "Level9" && flagdead == false)
            {
                GameManager.muertes9 += 1;

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "nivel", 9 }   }
                );
                flagdead = true;
            }
            else if (sceneName == "Level10" && flagdead == false)
            {
                GameManager.muertes10 += 1;

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "nivel", 10}   }
                );
                flagdead = true;
            }



            if (Input.GetKeyDown (KeyCode.R)) {

                //VideoPlay.showoOne = false;

                if (sceneName == "Level1")
            {
                
                Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                {  { "nivel", 1 }   }
                );
               
            }
            else if (sceneName == "Level2")
            {
                
                Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                {  { "nivel", 2 }   }
                );
               
            }
            else if (sceneName == "Level3")
            {
                Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                {  { "nivel", 3 }   }
                );
              
            }
            else if (sceneName == "Level4")
            {
                Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                {  { "nivel", 4 }   }
                );
              
            }
            else if (sceneName == "Level5")
            {
                Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                {  { "nivel", 5 }   }
                );
             
            }
            else if (sceneName == "Level6")
            {
                Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                {  { "nivel", 6 }   }
                );
                
            }
            else if (sceneName == "Level7")
            {
                Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                {  { "nivel", 7 }   }
                );
                
            }
            else if (sceneName == "Level8")
            {
                Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                {  { "nivel", 8 }   }
                );
                
            }
            else if (sceneName == "Level9")
            {
                Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                {  { "nivel", 9 }   }
                );
               
            }
            else if (sceneName == "Level10")
            {
                Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                {  { "nivel", 10}   }
                );
             
            }
                revivePlayer();                
                SceneManager.LoadScene (SceneManager.GetActiveScene().name);//remember to mention new scene manager using thing                


            }
		}
	}

	void killPlayer()
	{
		if (this.GetComponent<PlayerAnimate> ().enabled == true) {
			PlayerAnimate pa = this.GetComponent<PlayerAnimate> ();
			PlayerMovement pm = this.GetComponent<PlayerMovement> ();
			RotateToCursor rot = this.GetComponent<RotateToCursor> ();
			WeaponAttack wa = this.GetComponent<WeaponAttack> ();
			legDir ld = this.GetComponentInChildren<legDir> ();
			wa.dropWeapon ();
			pa.legs.sprite = null;
			pa.legs.enabled = false;
			ld.enabled = false;

			pa.torso.sprite = deadSpr;
			pa.enabled = false;

			rot.enabled = false;
			wa.enabled = false;

			pm.enabled = false;
			CircleCollider2D col = this.GetComponent<CircleCollider2D> ();
			col.enabled = false;
		}

       
    }

	void revivePlayer(){        
		PlayerAnimate pa = this.GetComponent<PlayerAnimate> ();
		PlayerMovement pm = this.GetComponent<PlayerMovement> ();
		RotateToCursor rot = this.GetComponent<RotateToCursor> ();
		WeaponAttack wa = this.GetComponent<WeaponAttack> ();
        dead = false;
        legDir ld = this.GetComponentInChildren<legDir> ();
		wa.dropWeapon ();
		pa.legs.enabled = true;
		ld.enabled = true;
		pa.enabled = true;
		rot.enabled = true;
		wa.enabled = true;
		pm.enabled = true;
		CircleCollider2D col = this.GetComponent<CircleCollider2D> ();
		col.enabled = true;
		
	}

	void OnGUI()
	{
		GUI.depth = 0;
		scale.x = Screen.width/originalWidth;
		scale.y = Screen.height/originalHeight;
		scale.z =1;
		var svMat = GUI.matrix;
		GUI.matrix = Matrix4x4.TRS(Vector3.zero,Quaternion.identity,scale);

		if (dead == true) {
			Rect posForRestart = new Rect (100,originalHeight-200,500,150);
			GUI.DrawTexture (posForRestart,bg);
			GUI.Box (posForRestart,"Press 'R' to restart",text);
		}

		GUI.matrix = svMat;
	}
}
