using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    void Start()
    {
        CreateWall();
    }

    void CreateWall()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject cubito = CreateCube(new Vector3(i, 0, 0));
            AddRigidbodyAndCollider(cubito);
        }

        for (int i = 0; i < 4; i++)
        {
            GameObject cubito = CreateCube(new Vector3(i + 0.5f, 0.5f, 0));
            AddRigidbodyAndCollider(cubito);
        }

        for (int i = 0; i < 5; i++)
        {
            GameObject cubito = CreateCube(new Vector3(i, 1, 0));
            AddRigidbodyAndCollider(cubito);
        }
    }

    GameObject CreateCube(Vector3 position)
    {
        GameObject cubito = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cubito.name = "Cubito";
        cubito.transform.position = position;
        cubito.transform.localScale = new Vector3(1, 0.5f, 0.5f);
        MeshRenderer mr = cubito.GetComponent<MeshRenderer>();
        mr.material.color = new Color(1, 1, 0);
        return cubito;
    }

    void AddRigidbodyAndCollider(GameObject cube)
    {
        Rigidbody rb = cube.AddComponent<Rigidbody>();
        rb.mass = 1f; // Ajustar mas sengún se requiera

        BoxCollider boxCollider = cube.AddComponent<BoxCollider>();
        boxCollider.size = new Vector3(1, 0.5f, 0.5f);
    }
}