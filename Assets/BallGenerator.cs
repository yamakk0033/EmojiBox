using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour {

    public GameObject ballPrefab;

    // Use this for initialization
    void Start () {
        
    }
    
    // Update is called once per frame
    void Update () {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject go = Instantiate(ballPrefab) as GameObject;
            //go.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            go.transform.position = new Vector3(0, 0, 0);
        }
    }
}
