using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDScript : MonoBehaviour
{
    float startTime = 600f;
    float time = 0f;
    Text timeText;

    // Start is called before the first frame update
    void Start()
    {
        time = startTime;
        timeText = GameObject.Find("Timer").GetComponent<Text>();


    }

    // Update is called once per frame
    void Update()
    {
        time -= 1 * Time.deltaTime;
        if (time <= 0)
        {
            time = 0;
        }
        string minutes = Mathf.Floor((time % 3600) / 60).ToString("00");
        string seconds = Mathf.Floor((time % 60)).ToString("00");
        timeText.text = minutes + ":" + seconds;
    }

    string timeFloattoString(float t)
    {
        string minutes = Mathf.Floor((t % 3600) / 60).ToString("00");
        string seconds = Mathf.Floor((t % 60)).ToString("00");
        string strTime = minutes + ":" + seconds;
        return strTime;
    }
}
