using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotScript : MonoBehaviour
{
    public bool hasSeed = false;
    public GameObject plantObject;
    // Start is called before the first frame update
    void Start()
    {
        plantObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (hasSeed)
        {
            plantObject.SetActive(true);

        }
    }

    void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.name == "seed") // if detector is detecting something that is not a player, set isEmpty as false
        {
            //Debug.Log("detected seed inside of pot");
            hasSeed = true;
            collision.gameObject.SetActive(false);
        }
    }
}
