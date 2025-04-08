using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelNext : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(1);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}
