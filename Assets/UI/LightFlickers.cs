using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlickers : MonoBehaviour
{
    [SerializeField] GameObject myLightObject;
    [SerializeField] bool isLightOn;
    [SerializeField] float flickerSpeed;

    private void Start()
    {
        isLightOn = true;
    }

    private void Update()
    {
        if (isLightOn == true)
        {
            StartCoroutine(TurnLightsOff());
        }
        if (isLightOn == false)
        {
            StartCoroutine(TurnLightsOn());
        }
    }

    IEnumerator TurnLightsOff()
    {
        yield return new WaitForSeconds(flickerSpeed + Time.deltaTime);
        LightsOff();
    }

    void LightsOff()
    {
        myLightObject.SetActive(false);
        isLightOn = false;
    }

    IEnumerator TurnLightsOn()
    {
        yield return new WaitForSeconds(flickerSpeed + Time.deltaTime);
        LightsOn();
    }

    void LightsOn()
    {
        myLightObject.SetActive(true);
        isLightOn = true;
    }
}
