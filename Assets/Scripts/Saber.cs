using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Saber : MonoBehaviour
{
    public LayerMask layer;
    private Vector3 previousPos;
    score thescore;

    void Start()
    {
        thescore = FindObjectOfType<score>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 1, layer))
        {
            if (Vector3.Angle(transform.position - previousPos, hit.transform.up) >= -90)
            {
                //Destroy(transform.gameObject, 2.0f);
                thescore.IncreaseScore();
            }
        }
        previousPos = transform.position;
    }
}
