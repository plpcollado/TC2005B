using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robot : MonoBehaviour
{
    //public GameObject bala;
    List<GameObject> robotArms;
    // Start is called before the first frame update
    void Start()
    {
        robotArms = new List<GameObject>();
        // BODY:
        GameObject body = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        body.transform.SetParent(GameObject.Find("ROBOT").transform);
        // LEFT ARM:
        GameObject lArm = GameObject.CreatePrimitive(PrimitiveType.Cube);
        lArm.transform.localScale = new Vector3(0.5f, 0.5f, 1f);
        lArm.transform.position = new Vector3(-0.5f, 0.0f, 0.0f);
        lArm.transform.SetParent(GameObject.Find("ROBOT").transform);
        robotArms.Add(lArm);
        // RIGHT ARM:
        GameObject rArm = GameObject.CreatePrimitive(PrimitiveType.Cube);
        rArm.transform.localScale = new Vector3(0.5f, 0.5f, 1f);
        rArm.transform.position = new Vector3(0.5f, 0.0f, 0.0f);
        rArm.transform.SetParent(GameObject.Find("ROBOT").transform);
        robotArms.Add(rArm);

        gameObject.transform.position = new Vector3(0, 0, -5);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position = gameObject.transform.position + new Vector3(-0.01f, 0, 0);
        }
        if(Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position = gameObject.transform.position + new Vector3(0.01f, 0, 0);
        }
        if(Input.GetKey(KeyCode.W))
        {
            gameObject.transform.position = gameObject.transform.position + new Vector3(0, 0, 0.01f);
        }
        if(Input.GetKey(KeyCode.S))
        {
            gameObject.transform.position = gameObject.transform.position + new Vector3(0, 0, -0.01f);
        }   
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject disparo = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            disparo.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);

            //Alternate shooting arms
            disparo.transform.position = robotArms[0].transform.position + new Vector3(0, 0, -0.7f);
            robotArms.Reverse();

            Rigidbody rb = disparo.AddComponent<Rigidbody>();   
            rb.mass = 5;
            rb.AddForce(new Vector3(0, 0, 10000));
            Destroy(disparo, 5.0f);
        }
    }
}
