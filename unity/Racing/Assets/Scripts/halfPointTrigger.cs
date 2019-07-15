using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class halfPointTrigger : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    // when half-way point is crossed
    void OnTriggerEnter () {
        // turn on lap trigger
        LapCompleteTrig.SetActive(true);
        // turn off half-lap trigger
        HalfLapTrig.SetActive(false);
    }
}
