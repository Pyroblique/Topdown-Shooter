using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, 0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward / 2);

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up * 10);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.down * 10);
        }

        RaycastHit hitPoint;
        // To detect what is directly in front of or closest to us
        if (Input.GetKeyDown(KeyCode.Space) && Physics.Raycast(transform.position, transform.forward, out hitPoint))
        {
            print(hitPoint.transform.name);


        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Gravity>() != null)
        {


            // Destroy object
            Destroy(gameObject);

        }
    }


}
