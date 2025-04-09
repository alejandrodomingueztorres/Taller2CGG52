using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform John;
    public float tiempo;

    void Update()
    {
        if (John != null)
        {
            //Vector3 position = transform.position;
           // position.x = John.position.x;
           // transform.position = position;
            
            Vector3 newPos = new Vector3(John.position.x, transform.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, newPos, tiempo*Time.deltaTime);
        }
    }
}
