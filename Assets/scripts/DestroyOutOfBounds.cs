using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float upperLimit = 30f;
    public float LowerLimit = -10f;

    private void Update()
    {
        if (transform.position.z < LowerLimit)
        {
            Destroy(gameObject);
            Debug.Log("GAME OVER");
            Time.timeScale = 0;
        }

        else if (transform.position.z > upperLimit) 
        {
            Destroy(gameObject);
        }
    }
}
