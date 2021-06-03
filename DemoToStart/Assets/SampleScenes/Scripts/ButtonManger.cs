using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonManger : MonoBehaviour
{
    public  Button a_btn;
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

    void Start()
    {
        Begin(a_btn, a_tt);
        Begin(b_btn, b_tt);
        Begin(c_btn, c_tt);
        Begin(d_btn, d_tt);
        Begin(e_btn, e_tt);
        Begin(f_btn, f_tt);
    }

    public void Begin(Button btn, Text tt)
    {
        btn = GameObject.Find("Button_object").GetComponent<Button>();
        tt = btn.transform.Find("Text").GetComponent<Text>();
        tt.text = "0";
    }

    public void onclick_a()
    {
        if (a_num < 2)
        {
            a_num++;
        }
        else
        {
            a_num = 0;
        }
        a_tt.text = a_num.ToString();
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
        b_tt.text = b_num.ToString();
    }

    public void onclick_c()
    {
        if (c_num < 2)
        {
            c_num++;
        }
        else
        {
            c_num = 0;
        }
        c_tt.text = c_num.ToString();
    }

    public void onclick_d()
    {
        if (d_num < 2)
        {
            d_num++;
        }
        else
        {
            d_num = 0;
        }
        d_tt.text = d_num.ToString();
    }

    public void onclick_e()
    {
        if (e_num < 2)
        {
            e_num++;
        }
        else
        {
            e_num = 0;
        }
        e_tt.text = e_num.ToString();
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
        f_tt.text = f_num.ToString();
    }




}
