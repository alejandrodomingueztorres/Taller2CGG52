using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MelonRecolected : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.Instance.SumValues(1);
            Destroy(gameObject);
        }
    }

}

