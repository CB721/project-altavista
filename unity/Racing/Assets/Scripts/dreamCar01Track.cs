using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dreamCar01Track : MonoBehaviour
{
    // Marker tally
    public GameObject TheMarker;
    // Reference to markers placed on course
    public GameObject Marker01;
    public GameObject Marker02;
    public GameObject Marker03;
    public GameObject Marker04;
    public GameObject Marker05;
    public GameObject Marker06;
    public GameObject Marker07;
    public GameObject Marker08;
    public GameObject Marker09;
    public GameObject Marker10;
    public GameObject Marker11;
    public GameObject Marker12;
    public GameObject Marker13;
    public GameObject Marker14;
    public GameObject Marker15;
    public GameObject Marker16;
    public GameObject Marker17;
    public GameObject Marker18;
    public GameObject Marker19;
    public GameObject Marker20;
    public GameObject Marker21;
    public GameObject Marker22;
    public GameObject Marker23;
    public GameObject Marker24;
    public GameObject Marker25;
    public GameObject Marker26;
    public GameObject Marker27;
    public GameObject Marker28;
    public GameObject Marker29;
    public GameObject Marker30;
    public GameObject Marker31;
    public GameObject Marker32;
    public GameObject Marker33;
    public GameObject Marker34;
    public GameObject Marker35;
    public GameObject Marker36;
    // Marker tally
    public int MarkTracker;

    // Update is called once per frame
    void Update()
    {
        // if tracker equal number
        // go to next marker
        if (MarkTracker == 0) {
            TheMarker.transform.position = Marker01.transform.position;
        }
        if (MarkTracker == 1) {
            TheMarker.transform.position = Marker02.transform.position;
        }
        if (MarkTracker == 2) {
            TheMarker.transform.position = Marker03.transform.position;
        }
        if (MarkTracker == 3) {
            TheMarker.transform.position = Marker04.transform.position;
        }
        if (MarkTracker == 4) {
            TheMarker.transform.position = Marker05.transform.position;
        }
        if (MarkTracker == 5) {
            TheMarker.transform.position = Marker06.transform.position;
        }
        if (MarkTracker == 6) {
            TheMarker.transform.position = Marker07.transform.position;
        }
        if (MarkTracker == 7) {
            TheMarker.transform.position = Marker08.transform.position;
        }
        if (MarkTracker == 8) {
            TheMarker.transform.position = Marker09.transform.position;
        }
        if (MarkTracker == 9) {
            TheMarker.transform.position = Marker10.transform.position;
        }
        if (MarkTracker == 10) {
            TheMarker.transform.position = Marker11.transform.position;
        }
        if (MarkTracker == 11) {
            TheMarker.transform.position = Marker12.transform.position;
        }
        if (MarkTracker == 12) {
            TheMarker.transform.position = Marker13.transform.position;
        }
        if (MarkTracker == 13) {
            TheMarker.transform.position = Marker14.transform.position;
        }
        if (MarkTracker == 14) {
            TheMarker.transform.position = Marker15.transform.position;
        }
        if (MarkTracker == 15) {
            TheMarker.transform.position = Marker16.transform.position;
        }
        if (MarkTracker == 16) {
            TheMarker.transform.position = Marker17.transform.position;
        }
        if (MarkTracker == 17) {
            TheMarker.transform.position = Marker18.transform.position;
        }
        if (MarkTracker == 18) {
            TheMarker.transform.position = Marker19.transform.position;
        }
        if (MarkTracker == 19) {
            TheMarker.transform.position = Marker20.transform.position;
        }
        if (MarkTracker == 20) {
            TheMarker.transform.position = Marker21.transform.position;
        }
        if (MarkTracker == 21) {
            TheMarker.transform.position = Marker22.transform.position;
        }
        if (MarkTracker == 22) {
            TheMarker.transform.position = Marker23.transform.position;
        }
        if (MarkTracker == 23) {
            TheMarker.transform.position = Marker24.transform.position;
        }
        if (MarkTracker == 24) {
            TheMarker.transform.position = Marker25.transform.position;
        }
        if (MarkTracker == 25) {
            TheMarker.transform.position = Marker26.transform.position;
        }
        if (MarkTracker == 26) {
            TheMarker.transform.position = Marker27.transform.position;
        }
        if (MarkTracker == 27) {
            TheMarker.transform.position = Marker28.transform.position;
        }
        if (MarkTracker == 28) {
            TheMarker.transform.position = Marker29.transform.position;
        }
        if (MarkTracker == 29) {
            TheMarker.transform.position = Marker30.transform.position;
        }
        if (MarkTracker == 30) {
            TheMarker.transform.position = Marker31.transform.position;
        }
        if (MarkTracker == 31) {
            TheMarker.transform.position = Marker32.transform.position;
        }
        if (MarkTracker == 32) {
            TheMarker.transform.position = Marker33.transform.position;
        }
        if (MarkTracker == 33) {
            TheMarker.transform.position = Marker34.transform.position;
        }
        if (MarkTracker == 34) {
            TheMarker.transform.position = Marker35.transform.position;
        }
        if (MarkTracker == 35) {
            TheMarker.transform.position = Marker36.transform.position;
        }
    }

    IEnumerator OnTriggerEnter(Collider collision) {
        // if it is the AI car
        if (collision.gameObject.tag == "DreamCar01") {
            // remove the box
            this.GetComponent<BoxCollider>().enabled = false;
            // add to marker tally
            MarkTracker += 1;
            // once the last marker is reached
            if (MarkTracker == 36) {
                MarkTracker = 0;
            }
            yield return new WaitForSeconds (1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
