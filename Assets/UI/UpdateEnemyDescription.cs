using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateEnemyDescription : MonoBehaviour
{
    TMP_Text _enemyDescriptionText;
    string _description;

    // Awake is called when the script instance is being loaded (only once, before Start())
    void Awake()
    {
        _enemyDescriptionText = GetComponent<TMP_Text>();    
    }

    void Start()
    {
        _description = GameManager.Instance.LastEnemyThatKilledPlayer.DeathScreenMessage;
        _enemyDescriptionText.SetText(_description);
        // _enemyDescriptionText.font = GameManager.Instance.LastEnemyThatKilledPlayer.DeathScreenFont;
    }
}
