using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnaMenu : MonoBehaviour
{
    public void OyunuBaslat()
    {   
        Points.skor = 0;
        Time.timeScale = 1;
        SceneManager.LoadScene(1);  
    }
    
    public void OyundanCik()
    {
        
         Application.Quit();
    }

}
