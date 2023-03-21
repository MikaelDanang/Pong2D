using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int PlayerScoreL = 0;
    public int PlayerScoreR = 0;

    // UI text
    public TMP_Text txtPlayerScoreL;
    public TMP_Text txtPlayerScoreR;

    public static GameManager instance;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        //nilai integer
        txtPlayerScoreL.text = PlayerScoreL.ToString();
        txtPlayerScoreR.text = PlayerScoreR.ToString();
    }

    public void ScoreCheck()
    {
        if (PlayerScoreL == 20)
        {
            Debug.Log("playerL win");
            this.gameObject.SendMessage("ChangeScene", "Menu");
        }
        else if (PlayerScoreR == 20)
        {
            Debug.Log("playerR win");
            this.gameObject.SendMessage("ChangeScene", "Menu");
        }
    }


    // penyeleksi untuk menambah score
    public void Score(string wallID)
    {
        if (wallID == "Line L")
        {
            PlayerScoreR = PlayerScoreR + 1;
            txtPlayerScoreR.text = PlayerScoreR.ToString();
            ScoreCheck();
        }
        else
        {
            PlayerScoreL = PlayerScoreL + 1;
            txtPlayerScoreL.text = PlayerScoreL.ToString();
            ScoreCheck();
        }
    }
}
