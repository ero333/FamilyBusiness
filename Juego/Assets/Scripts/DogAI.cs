using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Analytics;

public class DogAI : MonoBehaviour {
	GameObject player;
	public bool patrol = true,clockwise=false;
	public bool moving = true;
	public bool pursuingPlayer = false, goingToLastLoc=false;
	Vector3 target;
	Rigidbody2D rid;
	public Vector3 playerLastPos;
	RaycastHit2D hit;
	float speed = 2.0f; //changed bullets to be kenimatic
	int layerMask = 1<<8; //explain layermask for tutorial (how it works + changes to weapon attack)
	public GameObject bloodSpurt;
    string sceneName;


    // Use this for initialization
    void Start () {        
        sceneName = SceneManager.GetActiveScene().name;
        player = GameObject.FindGameObjectWithTag ("Player");
		playerLastPos = this.transform.position;
		rid = this.GetComponent<Rigidbody2D> ();
		layerMask = ~layerMask;

	}

	void Update () {

		if (PlayerHealth.dead == false) {
			movement ();
			playerDetect ();
		} else {
			this.GetComponent<DogAnimate> ().enabled = false;
		}



	}

	void movement()
	{
		float dist = Vector3.Distance (player.transform.position,this.transform.position);
		Vector3 dir = player.transform.position - transform.position;
		hit = Physics2D.Raycast(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(dir.x, dir.y),dist,layerMask);
		Debug.DrawRay(transform.position, dir, Color.red);

		Vector3 fwt = this.transform.TransformDirection(Vector3.right);

		RaycastHit2D hit2 = Physics2D.Raycast(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(fwt.x, fwt.y), 1.0f,layerMask);

		Debug.DrawRay (new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(fwt.x, fwt.y),Color.cyan);

		if(moving==true)//new for tut 7
		{
				transform.Translate (Vector3.right * speed * Time.deltaTime);
		}

			if (hit2.collider != null)
			{
				// Debug.LogError(hit2.collider.tag);
				if (hit2.collider.gameObject.tag == "Wall")
				{
					//Quaternion rot = this.transform.rotation;

					if (clockwise == false)
					{
						transform.Rotate(0, 0, 90);
					}
					else
					{
						transform.Rotate(0, 0, -90);
					}
				}

			}

		if(pursuingPlayer==true)
		{
			
			rid.transform.eulerAngles = new Vector3(0, 0, Mathf.Atan2((playerLastPos.y - transform.position.y), (playerLastPos.x - transform.position.x)) * Mathf.Rad2Deg);

			if (this.GetComponent<AudioSource> ().isPlaying == false) {
				this.GetComponent<AudioSource> ().Play ();
			}

			if (hit.collider.gameObject.tag == "Player") {
				playerLastPos = player.transform.position;
			} 

			if (Vector3.Distance (player.transform.position, this.transform.position) < 1.5f) {
				Instantiate (bloodSpurt, player.transform.position, this.transform.rotation);
				Instantiate (bloodSpurt, player.transform.position, player.transform.rotation);
				PlayerHealth.dead = true;
                Debug.Log("El player muere por perro");
                int level;
                if (sceneName == "Tutorial")
                {
                    level = 0;
                }
                else
                {
                    level = Utils.LevelFromSceneName(sceneName);

                }
                Debug.Log("nivel de Morir: " + level);
                Debug.Log("enemigo de Morir: " + this.gameObject.name);
                Debug.Log("tiempo de Morir: " + Time.timeSinceLevelLoad);
                Debug.Log("coordenada X de Morir: " + hit.collider.gameObject.transform.position.x);
                Debug.Log("coordenada Y de Morir: " + hit.collider.gameObject.transform.position.y);

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {   { "nivel", level },
                    { "enemigo", this.gameObject.name },
                    { "tiempo", Time.timeSinceLevelLoad },
                    { "CordenadasX", hit.collider.gameObject.transform.position.x },
                    { "CordenadasY", hit.collider.gameObject.transform.position.y }
                }
                );
                // el perro no usa arma
                Debug.Log("Insertar evento de morir");
                //Aca el player muere por el perro
            }

		}

		if(goingToLastLoc==true)
		{
			rid.transform.eulerAngles = new Vector3(0, 0, Mathf.Atan2((playerLastPos.y - transform.position.y), (playerLastPos.x - transform.position.x)) * Mathf.Rad2Deg);
			if (Vector3.Distance (this.transform.position, playerLastPos) < 1.5f) {
				//not found player, return to patrol
				patrol=true;
				goingToLastLoc = false;
			}

		}


		if (pursuingPlayer == true) {
			speed = 4.5f;
		} else if (goingToLastLoc == true) {
			speed = 3.7f;
		} else {
			speed = 2.0f;
		}


	}

	
	public void playerDetect()
	{
		Vector3 pos = this.transform.InverseTransformPoint(player.transform.position);



		if(hit.collider!=null)
		{

			if (hit.collider.gameObject.tag == "Player" && pos.x > 1.2f && Vector3.Distance(this.transform.position,player.transform.position)<9 ){

				patrol=false;
				pursuingPlayer = true;
			
			} else {
				if(pursuingPlayer==true)
				{
					goingToLastLoc = true;
					pursuingPlayer = false;
				}

			}
		}
	}

	public float getSpeed()
	{
		return speed;
	}



}
