using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class login : MonoBehaviour
{
    // TMP = TextMeshPro
    public TMP_InputField tmp_lista;
    public TMP_InputField tmp_grupo;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void HacerLogin()
    {
        string lista = tmp_lista.text;
        string grupo = tmp_grupo.text;
        Debug.Log("Usuario con grupo " + grupo + " y # de lista " + lista);
        SceneManager.LoadScene("Clase2");
    }
}
