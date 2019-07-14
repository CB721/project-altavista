using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lapComplete : MonoBehaviour
{
    public GameObject lapCompleteTrigger;
    public GameObject halfPointTrigger;

    public GameObject minuteDisplay;
    public GameObject secondDisplay;
    public GameObject milliDisplay;

    public GameObject lapTimeBox;

    void OnTriggerEnter () {
        // refering to lapTimeManager script
        if (lapTimeManager.secondCount <= 9) {
            secondDisplay.GetComponent<Text>().text = "0" + lapTimeManager.secondCount + ".";
        } else {
            secondDisplay.GetComponent<Text>().text = "" + lapTimeManager.secondCount + ".";
        }
        if (lapTimeManager.minuteCount <= 9) {
            minuteDisplay.GetComponent<Text>().text = "0" + lapTimeManager.minuteCount + ".";
        } else {
            minuteDisplay.GetComponent<Text>().text = "" + lapTimeManager.minuteCount + ".";
        }
        milliDisplay.GetComponent<Text>().text = "" + lapTimeManager.milliCount;

        lapTimeManager.minuteCount = 0;
        lapTimeManager.secondCount = 0;
        lapTimeManager.milliCount = 0;
        halfPointTrigger.SetActive(true);
        lapCompleteTrigger.SetActive(false);
    }
}
