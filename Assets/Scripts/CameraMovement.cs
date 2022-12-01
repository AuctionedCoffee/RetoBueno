using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Vector3 CameraPosition;
    [Header("Camera Settings")]
    public float CameraSpeed;
    // Start is called before the first frame update
    void Start()
    {
        CameraPosition = this.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(0, 0, -1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(1, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(-1, 0, 0);
        }
    }
}

            /*tranform.position += CameraSpeed /50;
        }
        
        
        this.transform.position = Camera CameraSpeed / 50;*/
