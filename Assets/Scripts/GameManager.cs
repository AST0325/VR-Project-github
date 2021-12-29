using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class GameManager : MonoBehaviour
{
    Block theblock;
    EndStage theEnd;
    private InputDevice targetDevice;
    public GameObject MenuObject;
    public GameObject SaberObject1;
    public GameObject SaberObject2;
    public GameObject InteractorObject1;
    public GameObject InteractorObject2;
    public InputDeviceCharacteristics controllerChracteristics;
    private float timeSpan;
    public float chekTime;

    // Start is called before the first frame update
    void Start()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDeviceCharacteristics leftControllerCharacteristics = InputDeviceCharacteristics.Left | InputDeviceCharacteristics.Controller;
        InputDevices.GetDevicesWithCharacteristics(leftControllerCharacteristics, devices);
        if (devices.Count > 0)
        {
            targetDevice = devices[0];
        }

        timeSpan = 0.0f;
        MenuObject.SetActive(false);
        ShowSaber();
        theblock = FindObjectOfType<Block>();
        theEnd = FindObjectOfType<EndStage>();
        AudioManager.instance.PlayBGM("LeeChunHyang");
    }

    public void ShowRay()
    {
        InteractorObject1.SetActive(true);
        InteractorObject2.SetActive(true);
        SaberObject1.SetActive(false);
        SaberObject2.SetActive(false);
    }

    public void ShowSaber()
    {
        InteractorObject1.SetActive(false);
        InteractorObject2.SetActive(false);
        SaberObject1.SetActive(true);
        SaberObject2.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (targetDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryValue)&&primaryValue)
        {
            timeSpan += Time.fixedDeltaTime;
            if (timeSpan > chekTime)
            {
                if (theblock.Switch == true)
                {
                    theblock.StopBlock();
                    theEnd.StopBlock();
                    AudioManager.instance.StopBGM();
                    MenuObject.SetActive(true);
                    ShowRay();
                }
                else /*(theblock.Switch == false)*/
                {
                    theblock.StartBlock();
                    theEnd.StartBlock();
                    AudioManager.instance.PlayBGM("LeeChunHyang");
                    MenuObject.SetActive(false);
                    ShowSaber();
                }
                timeSpan = 0;
            }
        }
    }
}