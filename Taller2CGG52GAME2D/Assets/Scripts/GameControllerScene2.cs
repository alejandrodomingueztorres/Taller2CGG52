using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameControllerScene2 : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI txtScore;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ShowScore();
    }
    public void ShowScore()
    {
        txtScore.text = GameManager.Instance.Score.ToString();
    }
}
