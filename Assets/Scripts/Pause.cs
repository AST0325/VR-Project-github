using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject SaberObjects;
    public GameObject InteractorObject;

    // Start is called before the first frame update
    void Start()
    {
        InteractorObject.SetActive(false);
        SaberObjects.SetActive(true);
    }

    public void ShowRay()
    {
        InteractorObject.SetActive(true);
        SaberObjects.SetActive(false);
    }

    public void ShowSaber()
    {
        InteractorObject.SetActive(false);
        SaberObjects.SetActive(true);
    }
}
