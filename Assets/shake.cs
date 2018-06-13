using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shake : MonoBehaviour {

    private Vector3 Acceleration;
    private int ShakeCount;
    public Text textCompornent;

    // Use this for initialization
    void Start () {
        ShakeCount = 0;
    }
    
    // Update is called once per frame
    void Update () {
        Vector3 preAcceleration = Acceleration;
        Acceleration = Input.acceleration;
        float DotProduct = Vector3.Dot(Acceleration, preAcceleration);
        if (DotProduct < 0)
        {
            ShakeCount++;
            Vibration.Vibrate(100);
        }

        textCompornent.text = "シェイク回数：" + ShakeCount.ToString();
    }
}
