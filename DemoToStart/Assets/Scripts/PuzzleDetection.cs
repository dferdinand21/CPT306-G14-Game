using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleDetection : MonoBehaviour
{
    public GameObject planetObject;
    public Transform pos;
    bool spawned = false;
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
        //if (collision.gameObject.name == planetObject.gameObject.name)
        if (planetObject.gameObject.name.Contains(collision.gameObject.name)) // if detector detects something that is the wanted object
        {
            //Debug.Log("detected right object");
            //collision.gameObject.SetActive(false);
            //Destroy(collision.gameObject);
            if (!spawned) // spawn replacement once, and deactivate
            {
                Instantiate(planetObject, pos.position, Quaternion.identity);
                collision.gameObject.SetActive(false);
                planetObject.SetActive(true);
                spawned = true;
                // move the detected object "into" the detector
                //collision.gameObject.transform.position = pos.position;
                // disable rigidbody
                //Rigidbody rb = planetObject.GetComponent<Rigidbody>();
                //rb.freezeRotation = true;
                //rb.isKinematic = false;
                // disable grab
                //collision.gameObject.GetComponent<ThrowObject>().beingCarried = false;
                //planetObject.GetComponent<ThrowObject>().enabled = false;
                gameObject.SetActive(false);
            }
            
            
        } else
        {
            //Debug.Log("Detected something, but is wrong thing");
        }
    }
}
