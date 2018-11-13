using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utils
{
    static public int LevelFromSceneName(string sceneName)
    {
        int level;

        if (int.TryParse(sceneName.Substring(5), out level))
        {
            return level;
        }
        else
        {
            return -1;
        }
    }
}
