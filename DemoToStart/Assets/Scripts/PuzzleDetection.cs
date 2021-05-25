using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleDetection : MonoBehaviour
{
    public GameObject planetObject;
    //Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        planetObject.SetActive(true);
        //Rigidbody rigidbody = planetObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.name == planetObject.gameObject.name) // if detector is detecting something that is not a player, set isEmpty as false
        {
            //Debug.Log("detected right object");

            // move the detected object "into" the detector
            collision.gameObject.transform.position = gameObject.transform.position;
            // disable rigidbody
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            rb.isKinematic = false;
            // disable grab
            collision.gameObject.GetComponent<ThrowObject>().enabled = false;
        } else
        {
            Debug.Log("Detected something, but is wrong thing");
        }
    }
}
