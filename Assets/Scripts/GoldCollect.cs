using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GoldCollect : MonoBehaviour
{
    // Start is called before the first frame update
    
    private void OnTriggerEnter2D(Collider2D collide)
    {
        if (collide.tag == "Player")
        {
            gameObject.SetActive(false);
            Points.skor += 500;
            Debug.Log(Points.skor);
        }

    }

}
