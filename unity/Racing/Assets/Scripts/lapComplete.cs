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
    public GameObject lapCounter;
    public int lapsDone;
    public float RawTime;
    public GameObject RaceFinish;

    void Update () {
        
    }

    void OnTriggerEnter()
    {
        // refering to lapTimeManager script
        lapsDone += 1;
        RawTime = PlayerPrefs.GetFloat("RawTime");
        if (lapTimeManager.Rawtime <= RawTime)
        {
            if (lapTimeManager.secondCount <= 9)
            {
                secondDisplay.GetComponent<Text>().text = "0" + lapTimeManager.secondCount + ".";
            }
            else
            {
                secondDisplay.GetComponent<Text>().text = "" + lapTimeManager.secondCount + ".";
            }
            if (lapTimeManager.minuteCount <= 9)
            {
                minuteDisplay.GetComponent<Text>().text = "0" + lapTimeManager.minuteCount + ".";
            }
            else
            {
                minuteDisplay.GetComponent<Text>().text = "" + lapTimeManager.minuteCount + ".";
            }
            milliDisplay.GetComponent<Text>().text = "" + lapTimeManager.milliCount;
        }


        PlayerPrefs.SetInt("MinSave", lapTimeManager.minuteCount);
        PlayerPrefs.SetInt("SecSave", lapTimeManager.secondCount);
        PlayerPrefs.SetFloat("MilliSave", lapTimeManager.milliCount);
        PlayerPrefs.SetFloat ("RawTime", lapTimeManager.Rawtime);

        lapTimeManager.minuteCount = 0;
        lapTimeManager.secondCount = 0;
        lapTimeManager.milliCount = 0;
        lapTimeManager.Rawtime = 0;
        lapCounter.GetComponent<Text>().text = "" + lapsDone;

        halfPointTrigger.SetActive(true);
        lapCompleteTrigger.SetActive(false);
        if (lapsDone == 3) {
            RaceFinish.SetActive(true);
        }
    }
}
