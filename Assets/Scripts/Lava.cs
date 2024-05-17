using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lava : MonoBehaviour
{
    private int zaman= 0;
    private void OnCollisionStay2D(Collision2D collision)
    {
        zaman++;
        if (zaman >= 8)
        {
            Points.skor -= Points.skor; 
             SceneManager.LoadScene(1);
        }
       
    }
}
