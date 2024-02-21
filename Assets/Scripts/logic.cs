using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Logic
{
    public static List<bool> bricks;

    public static void MakeBricks()
    {
        bricks = new List<bool>();
        for(int i = 0; i < 10; i++)
        {
            bricks.Add(false);
        }
        for(int i = 0; i < 5; i++)
        {
            int place = -1;
            do
            {
                place = Random.Range(0, 9);
            } while (bricks[place] == true);
            bricks[place] = true;
        }
    }
}
