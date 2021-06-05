using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleManager : MonoBehaviour
{
    public static PuzzleManager instance;
    public bool picIntroduction = false;
    public Text text_1;
    public Text text_2;
    public Text text_3;
    public Text text_4;
    public Text text_5;
    public Text text_6;
    public Text text_7;
    public Text task;
    public Button button;

    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    private void Update()
    {
        Button btn = button.GetComponent<Button>();

        if (picIntroduction == true)
        {
            Time.timeScale = 0;
            btn.gameObject.SetActive(true);
        }

        if (Input.GetMouseButtonDown(0) && picIntroduction != true)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "(1) Christ the Redeemer")
                {
                    picIntroduction = true;
                    text_1.gameObject.SetActive(true);
                }
                else if (hit.transform.name == "(2) Machu Picchu")
                {
                    picIntroduction = true;
                    text_2.gameObject.SetActive(true);
                }
                else if (hit.transform.name == "(3) Chichen Itza")
                {
                    picIntroduction = true;
                    text_3.gameObject.SetActive(true);
                }
                else if (hit.transform.name == "(4) Pyramid")
                {
                    picIntroduction = true;
                    text_4.gameObject.SetActive(true);
                }
                else if (hit.transform.name == "(5) Great Wall")
                {
                    picIntroduction = true;
                    text_5.gameObject.SetActive(true);
                }
                else if (hit.transform.name == "(6) Taj Mahal")
                {
                    picIntroduction = true;
                    text_6.gameObject.SetActive(true);
                }
                else if (hit.transform.name == "(7) Colosseum")
                {
                    picIntroduction = true;
                    text_7.gameObject.SetActive(true);
                }
                else if (hit.transform.name == "Task Reminder")
                {
                    picIntroduction = true;
                    task.gameObject.SetActive(true);
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.C) && picIntroduction == true)
        {
            Time.timeScale = 1;
            picIntroduction = false;
            text_1.gameObject.SetActive(false);
            text_2.gameObject.SetActive(false);
            text_3.gameObject.SetActive(false);
            text_4.gameObject.SetActive(false);
            text_5.gameObject.SetActive(false);
            text_6.gameObject.SetActive(false);
            text_7.gameObject.SetActive(false);
            task.gameObject.SetActive(false);
            btn.gameObject.SetActive(false);
        }

    }

}
