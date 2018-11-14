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
    public GameObject elevatorPosition;
    Vector3 initialPosition;
    

	void awake()
	{
        
    }

	// Use this for initialization
	void Start () {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        
        
        if (sceneName == "Level10")
        {
            initialPosition = this.gameObject.transform.position;

            if (GameManager.check10 == true)
            {
                this.gameObject.transform.position = elevatorPosition.transform.position;
                Destroy(GameObject.Find("enemigos Piso 0"));
            }

            else if (GameManager.check10 == false)
            {
                this.gameObject.transform.position = initialPosition;

            }
        }
        

    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("Tiempo actual de la escena: " + Time.timeSinceLevelLoad);
        //Debug.Log("El tiempo total del juego incluyendo reinicios: " + GameManager.tiempoTotalNivel);

        if (dead == true) {
            killPlayer();
            GameManager.playerPosition = this.transform.position;
            
            if (flagdead == false)
            {
                GameManager.muertes += 1;
                Debug.Log("el numero de muertes es: " + GameManager.muertes);
                
                flagdead = true;

            }
           

            if (Input.GetKeyDown (KeyCode.R)) {
                int level;
                if (sceneName == "Tutorial")
                {
                    level = 0;
                }
                else
                {
                    level = Utils.LevelFromSceneName(sceneName);

                }
                Debug.Log("nivel de ReiniciarNivel: " + level);
                Debug.Log("tiempo de ReiniciarNivel: " + Time.timeSinceLevelLoad);
                Debug.Log("enemigos muertos de ReiniciarNivel: " + ContarMuertos.contMuertos);
                Debug.Log("vez de ReiniciarNivel: " + GameManager.muertes);

                Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                {   { "nivel", level },
                    { "muertes", ContarMuertos.contMuertos },
                    { "tiempo",  Time.timeSinceLevelLoad},
                    { "vez", GameManager.muertes }
                }
                );


                if (Time.timeSinceLevelLoad > 0)
                {
                    GameManager.tiempoTotalNivel += Time.timeSinceLevelLoad;
                }

                Debug.Log("------------------------------------------------- Revive");
                Debug.Log("revivio personaje");
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

        dead = false;

        Debug.Log("PlayerHealth - revivePlayer");

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
