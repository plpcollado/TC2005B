using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prueba : MonoBehaviour
{
    GameObject cubito;
    // Start is called before the first frame update
    void Start()
    {
        cubito = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cubito.name = "Mi Cubito";
        cubito.transform.position = new Vector3(0,1,0);
        cubito.transform.localScale = new Vector3(1,2,1);

        MeshRenderer mr = cubito.GetComponent<MeshRenderer>();
        mr.material.color = new Color(1,1,0);

        Rigidbody rb = cubito.AddComponent<Rigidbody>();
        rb.mass = 10;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(Vector3.zero, new Vector3(1,0,0), Color.red);
        Debug.DrawLine(Vector3.zero, new Vector3(1,0,0), Color.green);
        Debug.DrawLine(Vector3.zero, new Vector3(1,0,0), Color.blue);
    }
}
