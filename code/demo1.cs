using UnityEngine;
using System.Collections;

public class DemoScript : MonoBehaviour {

    public Light myLight;

    void Update () {
        if (Input.GetKey ("space")) {
            myLight.enabled = true;
        } else {
            myLight.enabled = false;
        }
    }
}
