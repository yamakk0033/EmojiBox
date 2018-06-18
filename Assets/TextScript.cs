using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour {

    private int sc_width;
    private int sc_height;
    private Text comp;

    // Use this for initialization
    void Start () {
        sc_width = Screen.width;
        sc_height = Screen.height;
        comp = this.GetComponent<Text>();
    }
    
    // Update is called once per frame
    void Update () {

        Vector3 vec3 = Camera.main.ScreenToWorldPoint(new Vector3(sc_width, sc_height, 0));

        //Vector3 vec3 = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("width：{0}", sc_width).AppendLine();
        sb.AppendFormat("height：{0}", sc_height).AppendLine();
        sb.AppendLine();
        sb.AppendFormat("width：{0}", vec3.x).AppendLine();
        sb.AppendFormat("height：{0}", vec3.y).AppendLine();

        comp.text = sb.ToString();
    }
}
