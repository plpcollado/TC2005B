using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TMP_Text tmp_elapsed;
    public TMP_Text tmp_timer;

    public float elapsed;
    public float timer;
    public float timer_set;
    public int counter;
    // Start is called before the first frame update
    void Start()
    {
        timer_set = 25;
        elapsed = 0;
        timer = timer_set;
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        elapsed = Time.realtimeSinceStartup;
        timer -= Time.deltaTime;
        if(timer < 0)
        {
            timer = timer_set;
        }
        if (counter > 10)
        {
            tmp_elapsed.text = elapsed.ToString("F1");
            tmp_timer.text = timer.ToString("F1");
            counter = 0;
        }
        counter++;
    }
}
