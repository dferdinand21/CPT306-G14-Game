using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SMessage : MonoBehaviour
{
    public GameObject message;

    public void show()
    {
        message.SetActive(false);
    }
}
