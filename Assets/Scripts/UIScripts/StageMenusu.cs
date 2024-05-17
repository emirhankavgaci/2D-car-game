using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageMenusu : MonoBehaviour
{
   public void StageLoad1()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    
}
