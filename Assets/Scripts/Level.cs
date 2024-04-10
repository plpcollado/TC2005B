using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]

public class Level
{
    public int score;
    public string levelName;
    public bool finished;

    override public string ToString()
    {
        string txt = "USER:\n";
        txt += "id : " + score.ToString() + "\n";
        txt += "group : " + levelName + "\n";
        txt += "finished : " + finished.ToString() + "\n";
        return txt;
    }
}