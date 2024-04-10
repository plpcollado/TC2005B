using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class User 
{
    public int id;
    public int group;
    public string gender;
    public List<Level> levels;


    override public string ToString()
    {
            string txt = "USER:\n";
            txt += "id : " + id.ToString() + "\n";
            txt += "group : " + group.ToString() + "\n";
            txt += "gender : " + gender.ToString() + "\n";
            foreach (Level l in levels)
            {
                txt += l.ToString() + "\n";
            }
            return txt;

    }
}