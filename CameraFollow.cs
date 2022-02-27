using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{ 
    [SerializeField] private float mouseSensivity = 1f;// Mouse hassaslýðý için gerekli olan deðiþken
    [SerializeField] private Transform target;//kameranýn takip edeceði oyuncuya baðlý olan Target componentýnýn deðiþkeni
    [SerializeField] private Transform player;
    float mouseXaxis;// Mousedan gelicek X ekseni için gerekli input deðiþkeni
    float mouseYaxis;// Mousedan gelicek Y ekseni için gerekli input deðiþkeni

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void LateUpdate()// LateUpdate kullanmamýzdaki neden Kameranýn gerçek zamanlý konumlandýrýlmasýný saðlamak içindir yani - 
    //karakter Update'i çalýþdýrdýktan sonra LateUpdate Kamerayý karakterin durumuna göre konumlandýrcak
    {
        Rotate();
    }
    void Rotate()
    {
        mouseXaxis += Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;// X ekseni inputunu burada alýyoruz
        mouseYaxis -= Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;// Y ekseni inputunu burada alýyoruz

        mouseYaxis = Mathf.Clamp(mouseYaxis, -35, 60);
      
        transform.LookAt(target);

        target.rotation = Quaternion.Euler(mouseYaxis, mouseXaxis, 0);
        player.rotation = Quaternion.Euler(0, mouseXaxis, 0);
    }
}
