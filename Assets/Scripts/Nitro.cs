using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nitro : MonoBehaviour
{
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CarController car = collision.GetComponent<CarController>();
        if (car != null)
        {
            car.ApplyNitroBoost();
            Destroy(gameObject);
        }
    }
}
