using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemCounter : MonoBehaviour
{
    public PlayerMovement player;
    private TextMeshProUGUI itemCounterText;

    void Start()
    {
        itemCounterText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        int itemsLeft = 5 - player.itemsCollected.Count;
        if (itemCounterText != null)
        {
            itemCounterText.text = "Items left to collect: " + itemsLeft.ToString();
        }
        if(player.itemsCollected.Count == 5)
        {
            itemCounterText.text = "All items have been collected! Head to the door to leave.";
        }
    }
}
