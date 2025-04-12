using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameControllerScene1 : MonoBehaviour
    
{
    [SerializeField]
    private TextMeshProUGUI txtGemaScore;
    public GameObject PanelReinicio;

    // Start is called before the first frame update
    void Start()
    {
        PanelReinicio.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        ShowScore();
    }
    public void ShowScore()
    {
        //txtGemaScore.text = GameManager.Instance.Score.ToString();
    }
    public void ReiniciarNivel()
    {
        SceneManager.LoadScene("Scene1");
    }
}
