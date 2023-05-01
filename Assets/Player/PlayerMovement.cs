using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float horizontalMovement;
    float verticalMovement;
    [SerializeField] float movementSpeed = 5f;
    [SerializeField] bool canRun = false;
    [SerializeField] float runSpeed = 7.5f;
    GameObject WalkedOverItem;

    void Start()
    {
    }

    //when player collides into an enemy, they will be destroyed, not the enemy
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "target")
            Destroy(collision.gameObject);
    } 

    //detecting when player walks over an item to pick it up
    void OnTriggerEnter(Collider other)
    {
        WalkedOverItem = other.gameObject;
    }

    void OnTriggerExit(Collider other)
    {
        if(WalkedOverItem == this.gameObject)
            WalkedOverItem = null;
    }

    void PickUpItem()
    {
        if (Input.GetKeyDown(KeyCode.E))
            if(WalkedOverItem != null)
                Destroy(WalkedOverItem);
    }

    void MoveInDirection(Vector2 direction, float speed)
    {
        transform.Translate(direction * speed * Time.deltaTime, Space.World);
    }

    void Update()
    {
        HandleInput();
    }

    private void HandleInput()
    {
        horizontalMovement = Input.GetAxisRaw("Horizontal");
        verticalMovement = Input.GetAxisRaw("Vertical");
        Vector2 direction = new Vector2(horizontalMovement, verticalMovement);

        if(canRun)
            MoveInDirection(direction, runSpeed);
        else
            MoveInDirection(direction, movementSpeed);
    }
}
