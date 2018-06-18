using UnityEngine;

public class CreateFrame : MonoBehaviour {

    public GameObject boxPrefab;

    // Use this for initialization
    void Start () {
        Vector3 screenVec3 = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));

        this.CreateGameObject(new Vector3(0, + (screenVec3.y + 0.5f), 0), new Vector3(screenVec3.x * 2, 1, 1));
        this.CreateGameObject(new Vector3(0, - (screenVec3.y + 0.5f), 0), new Vector3(screenVec3.x * 2, 1, 1));

        this.CreateGameObject(new Vector3(+ (screenVec3.x + 0.5f), 0, 0), new Vector3(1, screenVec3.y * 2, 1));
        this.CreateGameObject(new Vector3(- (screenVec3.x + 0.5f), 0, 0), new Vector3(1, screenVec3.y * 2, 1));
    }

    // Update is called once per frame
    void Update () {
        
    }


    private GameObject CreateGameObject(Vector3 pos, Vector3 scale)
    {
        GameObject go = Instantiate(boxPrefab) as GameObject;
        go.transform.position = pos;
        go.transform.localScale = scale;

        return go;
    }
}
