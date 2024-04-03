using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public float timeLeft = 90f;

    
    public GameObject timeCounter;
    public GameObject GameOver;

    
    void Start()
    {

    }

    void Update()
    {
        
        timeLeft -= Time.deltaTime;



        UpdateUI();
    }

    void UpdateUI()
    {

        timeCounter.GetComponent<TextMeshProUGUI>().text = "Pozostały czas:" + Mathf.Floor(timeLeft).ToString();

        if (timeLeft <= 0)
            GameOver.SetActive(true);
    }
    public void OnWin()
    {
        GameOver.SetActive(true);
        GameOver.transform.Find("ReasonText").GetComponent<TextMeshProUGUI>().text = "Wygrałeś!";

    }
    public void OnLose()
    {
        GameOver.SetActive(true);
        GameOver.transform.Find("ReasonText").GetComponent<TextMeshProUGUI>().text = "Kamera cię zobaczyla!";
    }
}