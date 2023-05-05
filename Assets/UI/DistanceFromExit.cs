using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DistanceFromExit : MonoBehaviour
{
    [SerializeField] private GameObject door;
    private TextMeshProUGUI distanceCounterText;

    void Start()
    {
        distanceCounterText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        if (distanceCounterText != null && door != null)
        {
            float distance = Vector3.Distance(transform.position, door.transform.position);
            distanceCounterText.text = "Distance to door: " + distance.ToString("F2") + " feet";
        }
    }

}
