using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Analytics;

public class HeavyAttack : MonoBehaviour {
	public GameObject blood;
	float timer = 0.1f,timerReset=0.1f;
    string sceneName;
    SpriteContainer sc;



	GameObject player;

	//bool attacking = false;
	SpriteRenderer sr;
	HeavyAnimate ea;
	// Use this for initialization
	void Start () {
        sceneName = SceneManager.GetActiveScene().name;
        player = GameObject.FindGameObjectWithTag ("Player");
		ea = this.GetComponent<HeavyAnimate> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerHealth.dead == false) {//new for 10
			if (timer > 0) {
				timer -= Time.deltaTime;
			}


			if (timer <= 0 && Vector3.Distance (this.transform.position, player.transform.position) <= 1.6f) {
				if (ea.tCounter == ea.attackingSpr.Length - 1) {
					attack ();
				}
				ea.setAttacking ();
			}
		}
	}

	public void attack()
	{                  
			int layerMask = 1<<8;
			layerMask = ~layerMask;
			//pa.attack ();
			RaycastHit2D ray = Physics2D.Raycast (new Vector2(this.transform.position.x,this.transform.position.y),new Vector2(transform.right.x,transform.right.y),1.5f,layerMask);
			Debug.DrawRay (new Vector2(this.transform.position.x,this.transform.position.y),new Vector2(transform.right.x,transform.right.y),Color.green);
			Debug.Log ("Attempting melee attack");            
			if (ray.collider.gameObject.tag=="Player") {
				Debug.Log("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* HeavyAttack");
				PlayerHealth.dead= true;
            //Debug.Log("El player es matado por heavy");

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
            Debug.Log("coordenada X de Morir: " + ray.collider.gameObject.transform.position.x);
            Debug.Log("coordenada Y de Morir: " + ray.collider.gameObject.transform.position.y);
            // el heavy no usa arma
            Debug.Log("Insertar evento de morir");

            Analytics.CustomEvent("Morir", new Dictionary<string, object>
            {   { "nivel", level },
                { "enemigo", this.gameObject.name },
                { "tiempo", Time.timeSinceLevelLoad },
                { "CordenadasX", ray.collider.gameObject.transform.position.x },
                { "CordenadasY", ray.collider.gameObject.transform.position.y }
            }
            );


            // Aca el player muere por heavy
            Instantiate (blood, player.transform.position, player.transform.rotation);
				this.GetComponent<AudioController> ().meleeAttack ();
			} 

			timer = timerReset;
	}


}
