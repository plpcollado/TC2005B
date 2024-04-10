/*using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class login : MonoBehaviour
{
    // TMP = TextMeshPro
    public TMP_InputField tmp_lista;
    public TMP_InputField tmp_grupo;

    IEnumerator SendData(User u)
    {
        WWWForm formita = new WWWForm();
        formita.AddField("usuario", JsonUtility.ToJson(u));
        using (UnityWebRequest www = UnityWebRequest.Post("http://172.20.10.1:8001/tc2005b", formita))
        {
            // YIELD: Ceder el control de la ejecución
            yield return www.SendWebRequest();
            if(www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                string respuesta = www.downloadHandler.text;
                Debug.Log(respuesta);
            }
        }
    }

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
        //Debug.Log("Usuario con grupo " + grupo + " y # de lista " + lista);

        User u = new User();
        u.id = int.Parse(lista);
        u.grupo = int.Parse(grupo);
        //string json = JsonUtility.ToJson(u);
        //Debug.Log(json);
        StartCoroutine(SendData(u));

        //SceneManager.LoadScene("Clase2");
    }
}
*/