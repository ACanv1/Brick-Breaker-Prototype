using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tugla : MonoBehaviour
{
    public static int toplamtuglasayisi;
    public Sprite[] tuglalar;
    private int maxcarpma;
    private int carpmasayisi;
    // Start is called before the first frame update
    void Start()
    {
        maxcarpma = tuglalar.Length + 1;
        toplamtuglasayisi++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("top"))
        {
            carpmasayisi++;
            if (carpmasayisi>=maxcarpma)
            {
                toplamtuglasayisi--;
                Debug.Log(toplamtuglasayisi);
                if (toplamtuglasayisi<=0)
                {
                    GameObject.FindObjectOfType<OyunKontrol>().GetComponent<OyunKontrol>().birsonrakisahne();
                }
                Destroy(this.gameObject);
                
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = tuglalar[carpmasayisi - 1];
            }
        }
    }
}
