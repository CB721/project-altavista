using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraStable : MonoBehaviour
{
    public GameObject theCar;
    public float carXAxis;
    public float carYAxis;
    public float carZAxis;
    void Update()
    {
        // access car rotation x axis
        carXAxis = theCar.transform.eulerAngles.x;
        // access car rotation y axis
        carYAxis = theCar.transform.eulerAngles.y;
        // access car rotation z axis
        carZAxis = theCar.transform.eulerAngles.z;
        // car goes the opposite camera
        transform.eulerAngles = new Vector3(carXAxis - carXAxis, carYAxis, carZAxis - carZAxis);
    }
}
