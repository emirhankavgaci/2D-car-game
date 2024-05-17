using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenusu : MonoBehaviour
{
    [SerializeField] GameObject durdur;
    public void AnamenuDon()
    {
        Points.skor = 0;
        SceneManager.LoadScene(0);
        Time.timeScale = 0.1f;
        
    }

    public void YenidenBaslat()
    {
        Points.skor = 0;
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void DevamEt()
    {
        
        gameObject.SetActive(false);
        durdur.SetActive(true);
        Time.timeScale = 1;

        
    }
    public void Durdur()
    {
        Time.timeScale = 0;
        gameObject.SetActive(true);
        durdur.SetActive(false);
        
    }

}
