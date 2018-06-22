using System;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour {

    private Text comp;

    private int frameCount;
    private float elapsedTime;
    private float frameRate;

    // Use this for initialization
    void Start () {
        comp = this.GetComponent<Text>();

        frameCount = 0;
    }
    
    // Update is called once per frame
    void Update () {
        Vector3 vec3 = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));


        frameCount++;
        elapsedTime += Time.deltaTime;
        if (elapsedTime > 0.5f)
        {
            frameRate = frameCount / elapsedTime;
            frameCount = 0;
            elapsedTime = 0;
        }


        StringBuilder sb = new StringBuilder();
        sb.AppendLine("画面解像度");
        sb.AppendFormat("width：{0}", Screen.width).AppendLine();
        sb.AppendFormat("height：{0}", Screen.height).AppendLine();
        sb.AppendLine();
        sb.AppendLine("解像度をワールド座標に変換");
        sb.AppendFormat("width：{0}", vec3.x).AppendLine();
        sb.AppendFormat("height：{0}", vec3.y).AppendLine();
        sb.AppendLine();
        sb.AppendLine("加速度");
        sb.AppendFormat("x：{0}", Input.acceleration.x).AppendLine();
        sb.AppendFormat("y：{0}", Input.acceleration.y).AppendLine();
        sb.AppendFormat("z：{0}", Input.acceleration.z).AppendLine();
        sb.AppendLine();
        sb.AppendFormat("fps：{0}", frameRate).AppendLine();


        comp.text = sb.ToString();
    }
}
