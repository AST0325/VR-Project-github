using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndStage : MonoBehaviour
{
    Block theblock;

    private void Start()
    {
        theblock = FindObjectOfType<Block>();
    }

    public void StopBlock()
    {
        Time.timeScale = 0;
    }

    public void StartBlock()
    {
        Time.timeScale = 1;
    }

    private void FixedUpdate()
    {
        transform.position += Time.deltaTime * transform.forward * theblock.Speed;
    }

    private void OnTriggerStay(Collider other)
    {
        endStage();
    }

    public void endStage()
    {
        SceneManager.LoadScene("VR");
    }
}
