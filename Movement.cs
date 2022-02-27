using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class Movement : MonoBehaviour
{
    //H�z de�i�kenleri
    [SerializeField] private float moveS;// Hareket ederken kullan�lacak h�z de�i�keni
    [SerializeField] private float walkS;// Y�r�rken kullan�lacak h�z de�i�keni
    [SerializeField] private float runS;// Ko�arken kullan�lacak h�z de�i�keni

    //Ground de�i�kenleri
    [SerializeField] private bool grounded;// Oyuncunun yerde olum olmad���n� kontrol eden de�i�ken
    [SerializeField] private float groundDistance;// Yerlen olan mesafeyi �l�en de�i�ken
    [SerializeField] private LayerMask groundMask;// "Ground" layer�na karakterin de�di�ini anlamak i�in kullan�lan de�i�ken

    //Yer �ekimi
    [SerializeField] private float gravity;

    //Jumnp
    [SerializeField] private float jumpHeight;
    //[SerializeField] private float thrust = 20f;


    //Vector de�i�kenleri
    private Vector3 direction;// Haraket ederken al�nacak x,y,z y�nlerini tutucak olna vekt�r de�i�keni
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
        if (Input.GetKey(KeyCode.S))
        {
            WalkB();
        }
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
        direction = transform.TransformDirection(direction);//Burada her zaman yeni rotate �izmemizi sa�l�yoruz

        if (grounded)
        {
            if (direction != Vector3.zero && !Input.GetKey(KeyCode.LeftShift))
            {
                Walk();
            }
            else if (direction != Vector3.zero && Input.GetKey(KeyCode.LeftShift))
            {
                Run();
            }
            else if (direction != Vector3.zero && !Input.GetKey(KeyCode.LeftShift))
            {
                WalkB();
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
    private void WalkB()//Animasyon sorunu giderilinceye kadar kullan�lacak geri y�r�me animasyonu
    {
        moveS = walkS;
        anim.SetFloat("Speed", -0.5f, 0.1f, Time.deltaTime);
    }
}*/