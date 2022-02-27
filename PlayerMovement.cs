using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Hýz deðiþkenleri
    [SerializeField] private float moveS;// Hareket ederken kullanýlacak hýz deðiþkeni
    [SerializeField] private float walkS;// Yürürken kullanýlacak hýz deðiþkeni
    [SerializeField] private float runS;// Koþarken kullanýlacak hýz deðiþkeni

    //Ground deðiþkenleri
    [SerializeField] private bool grounded;// Oyuncunun yerde olum olmadýðýný kontrol eden deðiþken
    [SerializeField] private float groundDistance;// Yerlen olan mesafeyi ölçen deðiþken
    [SerializeField] private LayerMask groundMask;// "Ground" layerýna karakterin deðdiðini anlamak için kullanýlan deðiþken

    //Yer çekimi
    [SerializeField] private float gravity;

    //Jumnp
    [SerializeField] private float jumpHeight;

    //Vector deðiþkenleri
    private Vector3 direction;// Haraket ederken alýnacak x,y,z yönlerini tutucak olna vektör deðiþkeni
    [SerializeField] private Vector3 velocity;

    //Kontrol ve animasyon
    private Rigidbody PlayerRb;
    private CharacterController controller;
    private Animator anim;
    private void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponentInChildren<Animator>();
        PlayerRb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Move();
    }
    private void Move()
    {
        float vertical = Input.GetAxis("Vertical");

        grounded = controller.isGrounded;

        if (grounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        direction = new Vector3(0, 0, vertical);
        direction = transform.TransformDirection(direction);//Burada her zaman yeni rotate çizmemizi saðlýyoruz

        if (grounded)
        {
            if (direction != Vector3.zero && !Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.S))
            {
                Walk();
            }
            else if (direction != Vector3.zero && Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.S))
            {
                Run();
            }
            else if (direction != Vector3.zero && !Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.S))
            { 
                WalkB();
            }
            else if(direction != Vector3.zero && Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.S))
            {
                RunB();
            }
            direction *= moveS;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                jump();
            }
            else if (direction == Vector3.zero)
            {
                Idle();
            }
        }
        else
        {
            Idle();
        }
        controller.Move(direction * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
    private void Idle()
    {
        anim.SetFloat("Speed", 0, 0.1f, Time.deltaTime);
    }
    private void Walk()
    {
        moveS = walkS;
        anim.SetFloat("Speed", 0.5f, 0.1f, Time.deltaTime);
    }
    private void Run()
    {
        moveS = runS;
        anim.SetFloat("Speed", 1, 0.1f, Time.deltaTime);
    }
    private void jump()
    {
        velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        PlayerRb.AddForce(Vector3.up * 10);
        anim.SetTrigger("Jump");
    }
    private void WalkB()
    {
        moveS = walkS;
        anim.SetFloat("Speed", -0.5f, 0.1f, Time.deltaTime);
    }
    private void RunB()
    {
        moveS = runS;
        anim.SetFloat("Speed", -1, 0.1f, Time.deltaTime);
    }
}