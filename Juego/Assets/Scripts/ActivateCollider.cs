using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateCollider : MonoBehaviour {
    public GameObject collide;
    public GameObject animacionFinal;
    public GameObject[] life;


	// Use this for initialization
	void Start () {
        collide.SetActive(false);
        
	}
	
	// Update is called once per frame
	void Update () {
		if (PuertaMirtha.apagado == true)
        {
            collide.SetActive(true);
            
            
            if (GameManager.lifeBoss == 10)
            {
                
            }
            else if (GameManager.lifeBoss == 9)
            {
                Destroy(life[9]);
            }
            else if (GameManager.lifeBoss == 8)
            {
                Destroy(life[8]);
            }
            else if (GameManager.lifeBoss == 7)
            {
                Destroy(life[7]);
            }
            else if (GameManager.lifeBoss == 6)
            {
                Destroy(life[6]);
            }
            else if (GameManager.lifeBoss == 5)
            {
                Destroy(life[5]);
            }
            else if (GameManager.lifeBoss == 4)
            {
                Destroy(life[4]);
            }
            else if (GameManager.lifeBoss == 3)
            {
                Destroy(life[3]);
            }
            else if (GameManager.lifeBoss == 2)
            {
                Destroy(life[2]);
            }
            else if (GameManager.lifeBoss == 1)
            {
                Destroy(life[1]);
            }
            else if (GameManager.lifeBoss == 0)
            {
                Destroy(life[0]);
                animacionFinal.SetActive(true);
            }
            

        }
	}
}
