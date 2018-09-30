using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelect : MonoBehaviour {

    public string Level1;
    public string Level2;
    public string Level3;
    public string Level4;
    public string Level5;
    public string Level6;
    public string Level7;
    public string Level8;
    public string Level9;
    public string Level10;


    public void PlayLevel1()
    {
        Application.LoadLevel(Level1);
    }

    public void PlayLevel2()
    {
        Application.LoadLevel(Level2);
    }

    public void PlayLevel3()
    {
        Application.LoadLevel(Level3);
    }

    public void PlayLevel4()
    {
        Application.LoadLevel(Level4);
    }

    public void PlayLevel5()
    {
        Application.LoadLevel(Level5);
    }

    public void PlayLevel6()
    {
        Application.LoadLevel(Level6);
    }

    public void PlayLevel7()
    {
        Application.LoadLevel(Level7);
    }

    public void PlayLevel8()
    {
        Application.LoadLevel(Level8);
    }

    public void PlayLevel9()
    {
        Application.LoadLevel(Level9);
    }

    public void PlayLevel10()
    {
        Application.LoadLevel(Level10);
    }









    public void QuitGame()
    {
        Application.Quit();
    }

}
