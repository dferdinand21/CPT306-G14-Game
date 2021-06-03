using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject DWGame;
    public GameObject Introduction;

    // Start is called before the first frame update
    void Start()
    {
        Introduction.SetActive(true);
    }

    public void OnStart()
    {
        Introduction.SetActive(false);
        DWGame.SetActive(true);
    }
}
