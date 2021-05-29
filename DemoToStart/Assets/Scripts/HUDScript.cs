using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDScript : MonoBehaviour
{
    float time;
    Text timeText;

    // Start is called before the first frame update
    void Start()
    {
        timeText = GameObject.Find("Timer").GetComponent<Text>();


    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime * 1;
        string minutes = Mathf.Floor((time % 3600) / 60).ToString("00");
        string seconds = (time % 60).ToString("00");
        timeText.text = minutes + ":" + seconds;
    }
}
