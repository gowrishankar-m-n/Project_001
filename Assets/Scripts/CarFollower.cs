using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarFollower : MonoBehaviour
{

    public Transform carTransform;
    public Transform cameraTransform;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cameraTransform.position = new Vector3(carTransform.position.x, carTransform.position.y, -10f);
    }
}
