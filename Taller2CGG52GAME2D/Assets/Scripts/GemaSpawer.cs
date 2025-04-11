using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GemaSpawer : MonoBehaviour
{

    [SerializeField] private GameObject gemaPrefab; 
    [SerializeField] private int cantidadGemas = 5; 
    [SerializeField] private List<GameObject>  puntosDeSpawn;

    //float x = 12f;
    //float y = 45f;
    Vector2 nombreVector = new Vector2(12f, 45f);
    Vector2 nombreVector1 = Vector2.down;
    //Vector3


    // Start is called before the first frame update
    void Start()
    {
        GenerarGemas();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void GenerarGemas()
    {
        if (puntosDeSpawn.Count == 0)
        {
            Debug.LogWarning("No hay puntos de spawn asignados.");
            return;
        }

        // Si hay menos puntos que la cantidad de gemas, ajustamos
        int gemasAGenerar = Mathf.Min(cantidadGemas, puntosDeSpawn.Count);

        List<GameObject> puntosDisponibles = new List<GameObject>(puntosDeSpawn);

        for (int i = 0; i < gemasAGenerar; i++)
        {
            if (puntosDisponibles.Count == 0) break;

            int indiceAleatorio = Random.Range(0, puntosDisponibles.Count);
            GameObject puntoSeleccionado = puntosDisponibles[indiceAleatorio];

            Instantiate(gemaPrefab, puntoSeleccionado.transform.position, puntoSeleccionado.transform.rotation);

            puntosDisponibles.RemoveAt(indiceAleatorio); 
        }
    
}

    
}
