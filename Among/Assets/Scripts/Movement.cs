using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Movement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] InputAction movement;
    Vector2 mov;
    [SerializeField] float speed;
    SpriteRenderer[] renderer;
    private void OnEnable()
    {
        movement.Enable();
    }
    private void OnDisable()
    {
        movement.Disable();
    }
    void Start()
    {
        renderer = GetComponentsInChildren<SpriteRenderer>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        mov = movement.ReadValue<Vector2>();
        foreach  (SpriteRenderer s in renderer)
        {
            if (rb.velocity.x < 0)
            {
                s.flipX = true;
            }
            else
            {
                s.flipX = false;

            }
        }
        
    }
    private void FixedUpdate()
    {
        rb.velocity = mov * speed * Time.fixedDeltaTime;
    }

}
