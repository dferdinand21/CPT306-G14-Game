using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class change : MonoBehaviour
{
    public int sub_1 = 40;   //30
    public int sub_2 = 80;   //30
    public int sub_3;   //20
    public int sub_4 = 40;   //50
    public int sub_5;   //30
    public int total_b;
    public int total_d = 80;
    public int total_f = 40;
    public int[] sub1 = { 40, 0 };
    public int[] sub2 = { 0, 80 };
    public int[] sub4 = { 0, 40 };
    public int[] sub5 = { 0, 0 };


    public Button a_btn;
    public Text a_tt;
    public int a_num;

    public Button b_btn;
    public Text b_tt;
    public int b_num;

    public Button c_btn;
    public Text c_tt;
    public int c_num;

    public Button d_btn;
    public Text d_tt;
    public int d_num;

    public Button e_btn;
    public Text e_tt;
    public int e_num;

    public Button f_btn;
    public Text f_tt;
    public int f_num;

    public GameObject SuccessMessage;
    public GameObject FailMessage;
    public GameObject Game;

    void Start()
    {
        Begin(a_btn, a_tt, a_num);
        Begin(b_btn, b_tt, b_num);
        Begin(c_btn, c_tt, c_num);
        Begin(d_btn, d_tt, d_num);
        Begin(e_btn, e_tt, e_num);
        Begin(f_btn, f_tt, f_num);
    }

    public void Begin(Button btn, Text tt, int num)
    {
        btn = GameObject.Find("Button_object").GetComponent<Button>();
        tt = btn.transform.Find("Text").GetComponent<Text>();
        tt.text = "L";
        num = 0;
    }

    public void Reset(Text tt, int num)
    {
        tt.text = "L";
        num = 0;
    }

    public void onclick_a()
    {
        total_b = 0;

        if (a_num < 2)
        {
            a_num++;
        }
        else
        {
            a_num = 0;   
        }
        

        if (a_num == 0)
        {
            a_tt.text = "L";
            sub1[0] = 40;
        }
        else if (a_num == 1)
        {
            a_tt.text = "M";
            sub1[0] = (40 / 2);
            total_b = (40 / 2);
        }
        else
        {
            a_tt.text = "R";
            total_b = 40;
        }
        sub_1 = sub1[0] + sub1[1];
    }

    public void onclick_b()
    {
        if (b_num < 2)
        {
            b_num++;
        }
        else
        {
            b_num = 0;
        }
        
        if (b_num == 0)
        {
            b_tt.text = "L";
            sub_1 += total_b;    
        }
        else if (b_num == 1)
        {
            b_tt.text = "M";
            sub1[1] = (total_b / 2);
            sub2[0] = (total_b / 2);
        }
        else
        {
            b_tt.text = "R";
            sub2[0] += total_b;
        }
        sub_1 = sub1[0] + sub1[1];
        sub_2 = sub2[0] + sub2[1];
    }

    public void onclick_c()
    {
        total_d = 0;
        if (c_num < 2)
        {
            c_num++;
        }
        else
        {
            c_num = 0;
        }
        
        if (c_num == 0)
        {
            c_tt.text = "L";
            total_d = 80;
        }
        else if (c_num == 1)
        {
            c_tt.text = "M";
            total_d = (80 / 2);
            sub4[0] = (80 / 2);
        }
        else
        {
            c_tt.text = "R";
            sub4[0] = 80;
        }
        sub_4 = sub4[0] + sub4[1];
    }

    public void onclick_d()
    {
        sub_3 = 0;
        if (d_num < 2)
        {
            d_num++;
        }
        else
        {
            d_num = 0;
        }
        
        if (d_num == 0)
        {
            d_tt.text = "L";
            sub2[1] = total_d;
        }
        else if (d_num == 1)
        {
            d_tt.text = "M";
            sub2[1] = (total_d / 2);
            sub_3 = (total_d / 2);
        }
        else
        {
            d_tt.text = "R";
            sub_3 = total_d;
        }
        sub_2 = sub2[0] + sub2[1];
    }

    public void onclick_e()
    {
        total_f = 0;
        
        if (e_num < 2)
        {
            e_num++;
        }
        else
        {
            e_num = 0;
        }
        
        if (e_num == 0)
        {
            e_tt.text = "L";
            total_f = 40;
        }
        else if (e_num == 1)
        {
            e_tt.text = "M";
            total_f = (40 / 2);
            sub5[1] = (40 / 2);
        }
        else
        {
            e_tt.text = "R";
            sub5[1] = 40;
        }
        sub_5 = sub5[0] + sub5[1];
    }

    public void onclick_f()
    {
        
        if (f_num < 2)
        {
            f_num++;
        }
        else
        {
            f_num = 0;
        }
        
        if (e_num == 0)
        {
            f_tt.text = "L";
            sub4[1] = total_f;
        }
        else if (e_num == 1)
        {
            f_tt.text = "M";
            sub4[1] = (total_f / 2);
            sub5[0] = (total_f / 2);
        }
        else
        {
            f_tt.text = "R";
            sub5[0] = total_f;
        }
        sub_4 = sub4[0] + sub4[1];
        sub_5 = sub5[0] + sub5[1];
    }

    public void verify()
    {
        Game.SetActive(false);
        if(sub_1 == 30 && sub_2 == 30 && sub_3 == 20 && sub_4 == 50 && sub_5 == 30)
        {
            SuccessMessage.SetActive(true);
        }
        else
        {
            FailMessage.SetActive(true);
            sub_1 = 40;   //30
            sub_2 = 80;   //30
            sub_3 = 0;   //20
            sub_4 = 40;   //50
            sub_5 = 0;   //30
            total_b = 0;
            total_d = 80;
            total_f = 40;
            int[] sub1 = { 40, 0 };
            int[] sub2 = { 0, 80 };
            int[] sub4 = { 0, 40 };
            int[] sub5 = { 0, 0 };
            Reset(a_tt, a_num);
            Reset(b_tt, b_num);
            Reset(c_tt, c_num);
            Reset(d_tt, d_num);
            Reset(e_tt, e_num);
            Reset(f_tt, f_num);
        }
    }
}
