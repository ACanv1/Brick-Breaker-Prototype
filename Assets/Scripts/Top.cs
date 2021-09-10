using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Top : MonoBehaviour
{
    private GameObject pedal;
    private bool OyunBasladı = false;
    // Start is called before the first frame update
    void Start()
    {
        pedal = GameObject.FindObjectOfType<Pedal>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (!OyunBasladı)
        {
            transform.position = new Vector3(pedal.transform.position.x, transform.position.y, transform.position.z);
        }
        if (Input.GetMouseButtonDown(0))
        {
            OyunBasladı = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("AltDuvar"))
        {
            SceneManager.LoadScene("OyunuKaybettin");
        }
    }
}
