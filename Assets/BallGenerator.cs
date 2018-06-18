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
            Vector3 vec3 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            vec3.z = 0.0f;
            go.transform.position = vec3;
        }
    }
}
