using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpScene : MonoBehaviour
{
    //这个是跳转场景的方法
    public void Jump(string str) 
    {
        SceneManager.LoadScene(str);
    }
}
