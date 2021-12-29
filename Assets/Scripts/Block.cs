using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public float Speed = 20.4f;
    public bool Switch;
    ComboManager theCombo;

    void Start()
    {
        theCombo = FindObjectOfType<ComboManager>();
        StartBlock();
    }

    public void StopBlock()
    {
        Switch = false;
        Debug.Log("switch" + Switch);
        Time.timeScale = 0;
    }

    public void StartBlock()
    {
        Switch = true;
        Debug.Log("switch" + Switch);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += Time.deltaTime * transform.forward * Speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        theCombo.ResetCombo();
        Destroy(this.gameObject);
    }
}
