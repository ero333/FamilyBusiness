using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Analytics;

public class EnemyAttacked : MonoBehaviour {
	public Sprite knockedDown,stabbed,bulletWound,backUp;
	public GameObject bloodPool,bloodSpurt,bloodSpray;
	SpriteRenderer sr;
	bool EnemyKnockedDown=false;
	float knockDownTimer = 3.0f;
	GameObject player;
	ScoreController sc;
    string sceneName;
    public string nombreEnemigo;

	void Start () {
		sr = this.GetComponent<SpriteRenderer> ();
		player = GameObject.FindGameObjectWithTag ("Player");
		sc = GameObject.FindGameObjectWithTag ("GameController").GetComponent<ScoreController> ();
        sceneName = SceneManager.GetActiveScene().name;
        nombreEnemigo = this.gameObject.name;

    }
	

	void Update () {
		if(EnemyKnockedDown==true){
			knockDown ();

		}
	}

	public void knockDownEnemy()
	{
		EnemyKnockedDown = true;
	}

	void knockDown()
	{
        
        //Debug.Log("El enemigo nockeado es " + nombreEnemigo);
        int level;

        if (sceneName == "Tutorial")
        {
            level = 0;
        }
        else
        {
            level = Utils.LevelFromSceneName(sceneName);
            
        }
        
        // aqui se sabe que enemigo esta noqueado

        this.GetComponent<EnemyWeaponController> ().dropWeapon ();
		if (this.GetComponent<EnemyWeaponController> ().enabled==true) {
			sc.AddScore (500,this.transform.position);
			this.GetComponent<EnemyWeaponController> ().enabled=false;
		}

		knockDownTimer -= Time.deltaTime;
		sr.sprite = knockedDown;
		this.GetComponent<CircleCollider2D>().isTrigger=true;
		this.GetComponent<CircleCollider2D> ().radius = 1;
		sr.sortingOrder = 2;
		this.GetComponent<EnemyAI>().enabled=false;
		this.GetComponent<EnemyAnimate> ().disableLegs ();
		this.GetComponent<EnemyAnimate> ().enabled =false;
		if (this.GetComponent<AIPathFind> () == null) {

		}
		else{
			this.GetComponent<AIPathFind> ().enabled = false;
		}


		if (knockDownTimer <= 0) {
			EnemyKnockedDown = false;
			sr.sprite = backUp;

			this.GetComponent<CircleCollider2D>().isTrigger=false;
			this.GetComponent<CircleCollider2D> ().radius = 0.4f;
			this.GetComponent<EnemyAI> ().enabled = true;
			this.GetComponent<EnemyWeaponController> ().enabled=true;
			this.GetComponent<EnemyAnimate> ().enabled = true;//new for animate
			this.GetComponent<EnemyAnimate> ().enableLegs ();

			sr.sortingOrder = 5;
			knockDownTimer = 3.0f;
		}

	}

    /* killBullet() es la funcion para matar al enemigo con arma*/

	public void killBullet(Bullet bullet)
	{
		knockDownTimer = 9999;
		EnemyKnockedDown = false;


		sc.AddScore (500,this.transform.position);
		sc.increaseMultiplier ();
		this.GetComponent<EnemyWeaponController> ().dropWeapon ();
		this.GetComponent<EnemyWeaponController> ().enabled=false;
		sr.sprite = bulletWound;


		if (this.GetComponent<AIPathFind> () == null) {

		}
		else{
			this.GetComponent<AIPathFind> ().enabled = false;
		}
		Instantiate (bloodPool,this.transform.position,this.transform.rotation);
		sr.sortingOrder = 2;
		//disable ai
		this.GetComponent<EnemyAI>().enabled=false;
		this.GetComponent<CircleCollider2D>().enabled=false;
		this.GetComponent<EnemyAnimate> ().disableLegs ();
		this.GetComponent<EnemyAnimate> ().enabled =false;
		this.gameObject.tag = "Dead";

        Debug.Log("Kill Bullet con arma " + bullet.arma);
	}

	public void killMelee()
	{
		knockDownTimer = 9999;
		EnemyKnockedDown = false;


		sc.AddScore (1000,this.transform.position);
		sc.increaseMultiplier ();
		this.GetComponent<EnemyWeaponController> ().dropWeapon ();
		this.GetComponent<EnemyWeaponController> ().enabled=false;
		sr.sprite = stabbed;
		Instantiate (bloodPool,this.transform.position,this.transform.rotation);
		Instantiate (bloodSpurt,this.transform.position,player.transform.rotation);
		sr.sortingOrder = 2;
		if (this.GetComponent<AIPathFind> () == null) {

		}
		else{
			this.GetComponent<AIPathFind> ().enabled = false;
		}
		this.GetComponent<EnemyAI>().enabled=false;
		this.GetComponent<CircleCollider2D>().enabled=false;
		this.GetComponent<EnemyAnimate> ().disableLegs ();
		this.GetComponent<EnemyAnimate> ().enabled =false;
		this.gameObject.tag = "Dead";
        
	}

	public void execute()
	{
		knockDownTimer = 9999;
		EnemyKnockedDown = false;


		if (this.GetComponent<AIPathFind> () == null) {

		}
		else{
			this.GetComponent<AIPathFind> ().enabled = false;
		}
		sc.AddScore (500,this.transform.position);
		sc.increaseMultiplier ();
		this.GetComponent<EnemyWeaponController> ().dropWeapon ();
		this.GetComponent<EnemyWeaponController> ().enabled=false;
		sr.sprite = stabbed;
		Instantiate (bloodPool,this.transform.position,this.transform.rotation);
		Instantiate (bloodSpray,this.transform.position,this.transform.rotation);
	
		sr.sortingOrder = 2;
	
		this.GetComponent<EnemyAI>().enabled=false;
		this.GetComponent<CircleCollider2D>().enabled=false;
		this.GetComponent<EnemyAnimate> ().disableLegs ();
		this.GetComponent<EnemyAnimate> ().enabled =false;
		this.gameObject.tag = "Dead";
	}
}
