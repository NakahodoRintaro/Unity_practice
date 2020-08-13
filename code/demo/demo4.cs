using UnityEngine;
using System.Collections;

public class DemoScript : MonoBehaviour {

    public Light myLight;

    void Update () {
        if (Input.GetKeyDown ("space")) {
            MyFunction ();
        }
    }

    void MyFunction () {
        myLight.enabled = !myLight.enabled;
    }
}
