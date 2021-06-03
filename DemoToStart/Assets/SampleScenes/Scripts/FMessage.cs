using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FMessage : MonoBehaviour
{
    public GameObject message;
    public GameObject Game;

    public void show()
    {
        message.SetActive(false);
        Game.SetActive(true);
    }
}
