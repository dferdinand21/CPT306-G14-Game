using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SMessage : MonoBehaviour
{
    public GameObject message;

    public void show()
    {
        message.SetActive(false);
        SceneManager.LoadScene("Geography Classroom");
    }
}
