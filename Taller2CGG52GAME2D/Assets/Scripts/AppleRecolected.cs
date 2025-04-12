using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleRecolected : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //private void OnCollisionExit(Collision collision)
    //{
        
    //}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Apple Recolected "+ collision.tag);
        if (collision.CompareTag("Player"))
        {
            GameManager.Instance.SumValues(1); 
            Destroy(gameObject);
        }
    }

}
