using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    //[SerializeField] private EdgeCollider2D _ec; 

    // Update is called once per frame

    private float zaman;
    private void OnTriggerStay2D(Collider2D collision)
    {
        zaman++;
            if (zaman >= 2 && collision.tag == "Zemin")
            {
                Points.skor = 0;
                SceneManager.LoadScene(1);
            }
            
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        zaman = 0;
    }


    
}
