using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.name == "seed") // if detector is detecting something that is not a player, set isEmpty as false
        {
            Debug.Log("detected seed inside of pot");
        }
    }
}
