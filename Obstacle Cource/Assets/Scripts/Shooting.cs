using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public GameObject weapon;
    public GameObject crosshair;
    
    // Start is called before the first frame update
    void Start()
    {
       Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        ShootBullet();
    }
    void ShootBullet()
    {

        if (Input.GetMouseButtonDown(0))
        {
        Instantiate(bullet, weapon.transform.position, transform.rotation);
        }
    }
}
