using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;

public class EnemyWeaponController : MonoBehaviour {

	public GameObject oneHandSpawn,twoHandSpawn,bullet,blood,shotgunBullet;
	GameObject curWeapon;
	public bool gun = false;
	float timer = 999999999,timerReset=0.1f;
    public GameObject Boss;
	SpriteContainer sc;
    public string arma;
    public string asesino;
	float weaponChange = 0.5f;
	bool changingWeapon = false;
	bool oneHanded = false;
	bool shotgun = false;//new for new weapons (also in player weapon script)
	EnemyAI eai;
	GameObject player;
    private string sceneName;
    bool attacking = false;
	SpriteRenderer sr;
	EnemyAnimate ea;
	// Use this for initialization
	void Start () {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
		eai = this.GetComponent<EnemyAI> ();
		player = GameObject.FindGameObjectWithTag ("Player");
		sr = this.GetComponent<SpriteRenderer> ();
		sc = GameObject.FindGameObjectWithTag ("GameController").GetComponent<SpriteContainer> ();
		ea = this.GetComponent<EnemyAnimate> ();
        Boss = GameObject.Find("Mirtha");
	}

	// Update is called once per frame
	void Update () {
		//Vector3 mousePos = Camera.main.ScreenToWorldPoint (new Vector3(Input.mousePosition.x,Input.mousePosition.y,0));
		//Vector3 dir = mousePos - this.transform.position;//this.transform.TransformDirection (Vector3.up);

		if (gun == true) {
			eai.hasGun = true;
		} else {
			eai.hasGun = false;
		}

		if (timer > 0) {
			timer -= Time.deltaTime;
		}

		if (PlayerHealth.dead == false)
        {//new for 10
            //Debug.Log("timer " + timer);
           

            if (eai.hasGun == false && gun == false && eai.pursuingPlayer == true && timer <= 0 && Vector3.Distance (this.transform.position, player.transform.position) <= 1.6f)
            {
				if (ea.tCounter == ea.attackingSpr.Length - 3) {//new for heavy tut
                    Debug.Log("///////////////////////////////////////////////////////////////////////// 1");
					attack ();
				}
				ea.setAttacking ();
			} 
            
            else if (Boss != null && Boss.name == "Mirtha")
            {                         
             if (eai.hasGun == true && eai.pursuingPlayer == true && timer <= 0 && Vector3.Distance (this.transform.position, player.transform.position) <= 25.0f)
                {
                    Debug.Log("///////////////////////////////////////////////////////////////////////// 1");
                    attack ();
				ea.setAttacking ();
			    }
            }
            else if (Boss == null && eai.hasGun == true && eai.pursuingPlayer == true && timer <= 0 && Vector3.Distance (this.transform.position, player.transform.position) <= 5.0f) 
            {
                Debug.Log("///////////////////////////////////////////////////////////////////////// 1");
                attack ();
				ea.setAttacking ();
			} 
		}

		if(changingWeapon==true)
		{
			weaponChange -= Time.deltaTime;
			if(weaponChange<=0)
			{
				changingWeapon = false;
			}
		}
	}

	public bool getAttacking()
	{
		return attacking;//this and the all to do with the bool attacking are new for 
	}

	void decideSFX()
	{
		if (gun == true) {
			if (shotgun == true) {
				this.GetComponent<AudioController> ().fireShotgun ();
			} else {
				this.GetComponent<AudioController> ().fireSmg ();
			}
		} else {
			this.GetComponent<AudioController> ().meleeAttack ();
		}
	}

	public void setWeapon(GameObject cur, string name, float fireRate,bool gun,bool oneHanded, bool shot)
	{
		//this.GetComponent<AudioController> ().pickupWeapon ();
		changingWeapon = true;
		curWeapon = cur;
		this.gun = gun;
		timerReset = fireRate;
		timer = timerReset;
		this.oneHanded = oneHanded;
		ea.setTorsoSpr (name);
		shotgun = shot;
        arma = name;
        asesino = this.gameObject.name;


	}

	public void attack()
	{
		//pa.attack ();
		if (gun == true) {
			//pa.attack ();
			Bullet bl = bullet.GetComponent<Bullet> ();          
            
            Vector3 dir;
			dir.x = Vector2.right.x;
			dir.y = Vector2.right.y;
			dir.z = 0;
			
			if(oneHanded==true)
			{
				if (shotgun == false) {//new for new weapons

                    //Bullet bl = Instantiate(bullet, oneHandSpawn.transform.position, this.transform.rotation).GetComponent<Bullet>();
                    bl.arma = arma;
                    bl.asesino = this.gameObject.name;
                    Debug.Log("El arma del enemigo es: " + bl.arma);

                    Instantiate (bullet, oneHandSpawn.transform.position, this.transform.rotation);
				} else {

                    //Instantiate (shotgunBullet, oneHandSpawn.transform.position, this.transform.rotation);
                    GameObject go = Instantiate(shotgunBullet, oneHandSpawn.transform.position, this.transform.rotation);
                    Bullet[] bullets = go.GetComponentsInChildren<Bullet>();

                    foreach (Bullet b in bullets)
                    {
                        b.arma = arma; // o el arma que sea          
                        b.asesino = this.gameObject.name;                        
                        Debug.Log("El arma del enemigo es: " + b.arma);
                        Debug.Log("El enemigo es: " + b.asesino);

                    }
                }
				decideSFX ();
			}
			else{
				if (shotgun == false) {//new for new weapons
                    //Bullet bl = Instantiate(bullet, oneHandSpawn.transform.position, this.transform.rotation).GetComponent<Bullet>();
                    bl.arma = arma;
                    Debug.Log("El arma del enemigo es: " + bl.arma);
                    Instantiate (bullet, twoHandSpawn.transform.position, this.transform.rotation);
				} else {
                    //Instantiate (shotgunBullet, twoHandSpawn.transform.position, this.transform.rotation);
                    GameObject go = Instantiate(shotgunBullet, oneHandSpawn.transform.position, this.transform.rotation);
                    Bullet[] bullets = go.GetComponentsInChildren<Bullet>();

                    foreach (Bullet b in bullets)
                    {
                        b.arma = arma; // o el arma que sea                        
                        Debug.Log("El arma del enemigo es: " + b.arma);

                    }
                }
				decideSFX ();
			}
			timer = timerReset;

			//if (Input.GetMouseButtonUp (0)) {
			//pa.resetCounter ();
			//}

		} else {
			//melee attack
			int layerMask = 1<<8;
			layerMask = ~layerMask;
			//pa.attack ();
			RaycastHit2D ray = Physics2D.Raycast (new Vector2(this.transform.position.x,this.transform.position.y),new Vector2(transform.right.x,transform.right.y),1.5f,layerMask);
			Debug.DrawRay (new Vector2(this.transform.position.x,this.transform.position.y),new Vector2(transform.right.x,transform.right.y),Color.green);
			Debug.Log ("Attempting melee attack");            
            if (curWeapon == null && ray.collider.gameObject.tag=="Player") {
				Debug.Log("Punching player");
				Debug.Log("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* EnemyWeaponController");
				PlayerHealth.dead = true;                
                Instantiate (blood, player.transform.position, player.transform.rotation);
				//EnemyAttacked ea = ray.collider.gameObject.GetComponent<EnemyAttacked> ();
				//ea.knockDownEnemy ();
				decideSFX ();
			} else if(ray.collider != null) {
				
				if (ray.collider.gameObject.tag == "Player") {
					Debug.Log ("Melee attacking player");
					Debug.Log("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* EnemyWeaponController");
					PlayerHealth.dead = true;
                    //Debug.Log("el arma melee con el que me mato es " + arma);

                    int level;
                    if (sceneName == "Tutorial")
                    {
                        level = 0;
                    }
                    else
                    {
                        level = Utils.LevelFromSceneName(sceneName);

                    }
                    Debug.Log("nivel de Morir es: " + level);
                    Debug.Log("enemigo de Morir: " + this.gameObject.name);
                    Debug.Log("tiempo de Morir: " + Time.timeSinceLevelLoad);
                    Debug.Log("coordenada X de Morir: " + player.transform.position.x);
                    Debug.Log("coordenada Y de Morir: " + player.transform.position.y);
                    Debug.Log("arma de Morir: " + arma);
                    Debug.Log("Insertar evento de morir");

                    Analytics.CustomEvent("Morir", new Dictionary<string, object>
                    {   { "nivel", level },
                        { "enemigo", this.gameObject.name },
                        { "tiempo", Time.timeSinceLevelLoad },
                        { "CordenadasX", player.transform.position.x },
                        { "CordenadasY", player.transform.position.y },
                        //{ "Arma", arma }
                    }
                    );

                    //Aca insertar variable de morir con arma pero melee.
                    Instantiate (blood, player.transform.position, player.transform.rotation);
					decideSFX ();
					//EnemyAttacked ea = ray.collider.gameObject.GetComponent<EnemyAttacked> ();
					//ea.killMelee ();
				}
			}

			timer = timerReset;
		}


	}

	public GameObject getCur()
	{
		return curWeapon;
	}

	public void dropWeapon()
	{
		if (curWeapon == null) {

		} else {
			Vector3 mousePos = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 0));
			curWeapon.AddComponent<ThrowWeapon> ();
			Vector3 dir;
			dir.x = mousePos.x - this.transform.position.x;
			dir.y = mousePos.y - this.transform.position.y;
			dir.z = 0;
			curWeapon.GetComponent<Rigidbody2D> ().isKinematic = false;
			//curWeapon.GetComponent<ThrowWeapon> ().setDirection (dir); Para que los enemigos dropeen las armas pero no puedan arrojarte sus armas
			curWeapon.transform.position = oneHandSpawn.transform.position;
			curWeapon.transform.eulerAngles = this.transform.eulerAngles;
			curWeapon.SetActive (true);
			setWeapon (null, "", 0.5f, false,false,false);
			//pa.resetSprites ();
		}

	}
}
