using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ContCreditos : MonoBehaviour {
    public static int contCreditos = 0;
    public static int contControles = 0;
    private string sceneName;

    private void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;

        if (sceneName == "Controls")
        {
            contControles++;
            Analytics.CustomEvent("VerControles", new Dictionary<string, object>
        {  { "vez", ContCreditos.contControles }   }
            );
        }
    }

    private void Update()
    {
        Debug.Log(contCreditos);
        Debug.Log("Cantidad de veces apretada controles " + contControles);
    }
}
