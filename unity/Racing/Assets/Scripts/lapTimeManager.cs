using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lapTimeManager : MonoBehaviour
{
    public static int minuteCount;
    public static int secondCount;
    public static float milliCount;
    public static string milliDisplay;

    public GameObject minuteBox;
    public GameObject secondBox;
    public GameObject milliBox;
    // Update is called once per frame
    void Update()
    {
        // convert delta time to milliseconds
        milliCount += Time.deltaTime * 10;
        // formatting for milliseconds
        milliDisplay = milliCount.ToString("F0");
        // display milliseconds
        milliBox.GetComponent<Text>().text = "" + milliDisplay;
        // when milliseconds reaches 10
        if (milliCount >= 10) {
            // set to 0
            milliCount = 0;
            // add to seconds
            secondCount += 1;
        }
        // when seconds under 9
        if (secondCount <= 9) {
            // display as :09 instead of :90
            secondBox.GetComponent<Text>().text = "0" + secondCount + ".";
        } else {
            // if greated than 9
            secondBox.GetComponent<Text>().text = "" + secondCount + ".";
        }
        // when seconds reaches 60
        if (secondCount >= 60) {
            // set to 0
            secondCount = 0;
            // add to minutes
            minuteCount += 1;
        }
        // when minutes under 9
        if (minuteCount <= 9) {
            minuteBox.GetComponent<Text>().text = "0" + minuteCount + ":";
        } else {
            minuteBox.GetComponent<Text>().text = "" + minuteCount + ":";
        }

    }
}
