using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{ 
    [SerializeField] private float mouseSensivity = 1f;// Mouse hassasl��� i�in gerekli olan de�i�ken
    [SerializeField] private Transform target;//kameran�n takip edece�i oyuncuya ba�l� olan Target component�n�n de�i�keni
    [SerializeField] private Transform player;
    float mouseXaxis;// Mousedan gelicek X ekseni i�in gerekli input de�i�keni
    float mouseYaxis;// Mousedan gelicek Y ekseni i�in gerekli input de�i�keni

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void LateUpdate()// LateUpdate kullanmam�zdaki neden Kameran�n ger�ek zamanl� konumland�r�lmas�n� sa�lamak i�indir yani - 
    //karakter Update'i �al��d�rd�ktan sonra LateUpdate Kameray� karakterin durumuna g�re konumland�rcak
    {
        Rotate();
    }
    void Rotate()
    {
        mouseXaxis += Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;// X ekseni inputunu burada al�yoruz
        mouseYaxis -= Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;// Y ekseni inputunu burada al�yoruz

        mouseYaxis = Mathf.Clamp(mouseYaxis, -35, 60);
      
        transform.LookAt(target);

        target.rotation = Quaternion.Euler(mouseYaxis, mouseXaxis, 0);
        player.rotation = Quaternion.Euler(0, mouseXaxis, 0);
    }
}
