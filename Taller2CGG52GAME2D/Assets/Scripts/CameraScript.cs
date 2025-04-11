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
         Vector3 position = transform.position;
         position.x = John.position.x;
         transform.position = position;
        }
    }
}
