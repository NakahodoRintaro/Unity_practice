using UnityEngine;
using System.Collections;

public class DemoScript : MonoBehaviour {

    public Light myLight;

    void Awake () {
        int myVar = AddTwo(9,2);
        Debug.Log(myVar);
    }

    void Update () {
        if (Input.GetKeyDown ("space")) {
            MyFunction ();
        }
    }

    void MyFunction () {
        myLight.enabled = !myLight.enabled;
    }

    string AddTwo (int var1, int var2) {
        int returnValue = var1 + var2;
        return returnValue;
    }
}
