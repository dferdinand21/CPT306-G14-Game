using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpScene : MonoBehaviour
{
    //�������ת�����ķ���
    public void Jump(string str) 
    {
        SceneManager.LoadScene(str);
    }
}
