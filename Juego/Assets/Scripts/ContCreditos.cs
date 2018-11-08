using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class ContCreditos : MonoBehaviour {
    public static int contCreditos = 0;
    public static int contControles = 0;

    private void Start()
    {
        contControles++;
        Analytics.CustomEvent("VerControles", new Dictionary<string, object>
        {  { "vez", contControles }   }
        );
    }

    private void Update()
    {
        Debug.Log(contCreditos);
        Debug.Log("Cantidad de veces apretada controles " + contControles);
    }
}
