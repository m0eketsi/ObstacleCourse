using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 10f;
    [SerializeField] private float _rotateSpeed = 70f;
    public float sensitivity = 10f;
    public float maxYAngle = 80f;
    private Vector2 currentRotation;
    public GameObject playerCam;
    public GameObject gameWonScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        FreeCamera();
    }

    void Movement()
    {
        float xValue = Input.GetAxis("Horizontal") * _rotateSpeed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime;

        transform.Translate(0f, 0f, zValue);
        transform.Rotate(0f, xValue, 0f);
    }
    void FreeCamera()
    {
        currentRotation.x += Input.GetAxis("Mouse X") * sensitivity;
        currentRotation.y -= Input.GetAxis("Mouse Y") * sensitivity;
        currentRotation.x = Mathf.Repeat(currentRotation.x, 360);
        currentRotation.y = Mathf.Clamp(currentRotation.y, -maxYAngle, maxYAngle);
        playerCam.transform.rotation = Quaternion.Euler(currentRotation.y,currentRotation.x,0);
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Objective"))
        {
            gameWonScreen.SetActive(true);
        }
    }
}