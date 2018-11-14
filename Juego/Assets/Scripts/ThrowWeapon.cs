using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;

public class ThrowWeapon : MonoBehaviour {
	EnemyAttacked attacked;
	float timer = 2.0f;
	Vector3 direction;
	Rigidbody2D rid;
    string sceneName;
    //GameObject player;
    // Use this for initialization

    void Start () {
        
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
		//player = GameObject.FindGameObjectWithTag ("Player");
		rid = this.GetComponent<Rigidbody2D> ();
		rid.AddForce (direction*40);
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.rotation = Quaternion.Slerp(this.transform.rotation,new Quaternion(this.transform.rotation.x,this.transform.rotation.y,this.transform.rotation.z-1,this.transform.rotation.w), Time.deltaTime * 10);
		timer -= Time.deltaTime;
		if(timer<=0)
		{
			rid.isKinematic = true;
			Destroy (this);
		}
        
	}


    public void setDirection(Vector3 dir)
	{
		direction = dir;
	}
    

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Enemy") {
			attacked = col.gameObject.GetComponent<EnemyAttacked> ();
			attacked.knockDownEnemy();
            int level;
            if (sceneName == "Tutorial")
            {
                level = 0;
            }
            else
            {
                level = Utils.LevelFromSceneName(sceneName);

            }

            Debug.Log("nivel de Noquear: " + level);
            Debug.Log("Enemigo de Noquear con arma: " + attacked.nombreEnemigo);
            Debug.Log("tiempo de Noquear: " + Time.timeSinceLevelLoad);                       
            Debug.Log("Insertar evento de noquear");

            /* PROBLEMA EN EL COLLIDER PORQUE LO TOMA MAS DE UNA VEZ
            Analytics.CustomEvent("Noquear", new Dictionary<string, object>
            {   { "nivel", level },
                { "enemigo", attacked.nombreEnemigo },
                { "tiempo", Time.timeSinceLevelLoad }
            }
            );
            */
            rid.isKinematic = true;
            Destroy (this);
            
        }
		else if(col.gameObject.tag=="Player")
		{
            
        }
		else if (col.gameObject.tag == "Dog") {
			col.gameObject.GetComponent<DogHealth> ().killDog ();
		}
		else if (col.gameObject.tag == "Wall") {
            rid.velocity = new Vector3(0, 0, 0);
		}
		else {
			rid.isKinematic = true;
			Destroy (this);

		}
	}
}
