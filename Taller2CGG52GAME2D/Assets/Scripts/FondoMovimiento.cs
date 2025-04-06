using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondoMovimiento : MonoBehaviour
{
    [SerializeField] private Vector2 velocidadMovimiento;
    private Vector2 offset;
    private Material material;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    

    private void Awake()
    {
        material = GetComponent<SpriteRenderer>().material;
    }

    private void Update() 
    {
        offset = velocidadMovimiento * Time.deltaTime;
        material.mainTextureOffset += offset;
    }
}
