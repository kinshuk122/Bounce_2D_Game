using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float sideForce = 5000f;
    public float jumpforce = 1f;

    public bool JumpReady;
    public float jumpCD = 3.0f;
    public float jump_Cooldown = 0.0f;
    [SerializeField] private Material Material;

    void Awake()
    {
        Material.color = Color.white;
    }




    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            rb.AddForce(new Vector2(sideForce * Time.deltaTime, 0));
        }
        

        if (Input.GetKey("a"))
        {
            rb.AddForce(new Vector2(-sideForce * Time.deltaTime, 0));
        }
    }

    void Update()
    {   

        if(jump_Cooldown >= jumpCD)
        {
            JumpReady = true;
        }
        else
        {
            jump_Cooldown = jump_Cooldown + Time.deltaTime;
            JumpReady = false;
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && JumpReady)
        {
            rb.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
            jump_Cooldown = 0.0f;
        }
    }
}
