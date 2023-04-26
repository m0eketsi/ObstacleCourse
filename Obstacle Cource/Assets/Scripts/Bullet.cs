using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 20;
    private Rigidbody bulletRB;
    public Vector3 crosshairPos;
    // Start is called before the first frame update
    void Start()
    {
        bulletRB = GetComponent<Rigidbody>();
        GameObject crosshair;
        crosshair = GameObject.Find("referenceCube");
        crosshairPos = crosshair.transform.position;
        transform.LookAt(crosshairPos);
    }

    // Update is called once per frame
    void Update()
    {
        bulletRB.velocity = transform.forward * bulletSpeed;
    }
}
