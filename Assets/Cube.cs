using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Cube : MonoBehaviour
{
    public float Speed = 1500f;
    public GameObject sphere;
    public GameObject cam;
    public GameObject bcam;
    public Text x;
    public int c;

    void Start()
    {
        
    }
    void FixedUpdate()
    {
        if (c <= 0)
        {
            //cam.SetActive(true);
            //bcam.SetActive(true);
            this.gameObject.SetActive(false);
            x.text = "it's over";
        }
        else x.text = c.ToString();

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.down * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.up * Speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        c--;
    }

    private void OnCollisionExit(Collision collision)
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        
    }


    void Update()
    {
        
    }
}
