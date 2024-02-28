using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

[RequireComponent(typeof(MeshCollider))]

public class ClickAndDrag : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;

    private void OnMouseDown()
    {
        Vector3 pos = gameObject.transform.position;
        screenPoint = Camera.main.WorldToScreenPoint(pos);
        Debug.Log("Touched" + gameObject.name + " at " + screenPoint);

        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        offset = pos - Camera.main.ScreenToWorldPoint(mousePos);
    }

    private void OnMouseDrag()
    {
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(mousePos) + offset;
        transform.position = curPosition;
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
