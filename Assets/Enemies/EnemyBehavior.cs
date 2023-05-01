using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField] EnemyData enemyData;
    public static Action<EnemyData> OnEnemyKilledPlayer;

    GameObject _player;
    float _distance;

    // Awake is called when the script instance is being loaded (only once, before Start())
    void Awake()
    {
        _player = GameObject.FindWithTag("target");
    }

    void Update()
    {
        HandleMovement();
    }

    void HandleMovement()
    {
        _distance = Vector2.Distance(transform.position, _player.transform.position);
        Vector2 direction = _player.transform.position - transform.position;

        if (_distance < enemyData.DetectionRange || enemyData.AlwaysChasePlayer)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, _player.transform.position, enemyData.Speed * Time.deltaTime);
        }
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.transform.CompareTag("target"))
        {
            KillPlayer();
        }
    }


    void KillPlayer()
    {
        OnEnemyKilledPlayer?.Invoke(enemyData);
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, enemyData.DetectionRange);
    }
}

