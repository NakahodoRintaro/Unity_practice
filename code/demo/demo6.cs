using UnityEngine;
using System.Collections;

[System.Serializable]
public class DataClass {
    public int myInt;
    public float myFloat;
}

public class DemoScript : MonoBehaviour {

    public Light myLight;
    public DataClass[] myClass;

    void Awake () {
        int myVar = AddTwo(9,2);
        Debug.Log(myVar);
    }

    void Update () {
        if (Input.GetKeyDown ("space")) {
            MyFunction ();
        }

        rigidbody.velocity = 10.0f;
    }

    void MyFunction () {
        myLight.enabled = !myLight.enabled;
    }

    string AddTwo (int var1, int var2) {
        int returnValue = var1 + var2;
        return returnValue;
    }
}
