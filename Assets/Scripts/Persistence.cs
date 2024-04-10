using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Persistence : MonoBehaviour
{
    // Start is called before the first frame update
    User u;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {
        // Normalmente "FromJSON" hace esto:
        u = new User();
        u.id = 1;
        u.group = 1;
        u.gender = "F";
        Level l1 = new Level();
        l1.score =100;
        l1.levelName = "Level 1";
        l1.finished =true;
        Level l2 = new Level();
        l2.score = 1;
        l2.levelName = "Level 2";
        l2.finished = false;
        u.levels = new List<Level>();
        u.levels.Add(l1);
        u.levels.Add(l2);
        Debug.Log(u);
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void CambiarEscena()
    {
        SceneManager.LoadScene("Persistence2");
    }
}
