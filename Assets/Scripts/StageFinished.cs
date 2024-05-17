using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFinished : MonoBehaviour
{

    private float _zaman2;

    private void OnTriggerStay2D(Collider2D other)
    {
        _zaman2++;
        if (other.tag == "Player" && _zaman2 >= 10)
        {
            Debug.Log("Tebirkler Kazandiniz!  Puan : "+ Points.skor);
            Points.skor =0;
            SceneManager.LoadScene(1);
        }
    }
}
