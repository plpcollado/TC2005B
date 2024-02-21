using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    void Start()
    {
        //CreateWall();
        Logic.MakeBricks();
        List<bool> lugares = Logic.bricks;

        foreach (bool b in lugares)
            Debug.Log(b);

        //Visualizar usand la lógica
        for (int x = 0; x < 10; x++)
        {
            float dx = x - 5 + 0.5f;
            if (lugares[x])
            {
                CreateCube(new Vector3(dx, 0.25f, 0), "tabique_" + x.ToString());
            }
        }


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
