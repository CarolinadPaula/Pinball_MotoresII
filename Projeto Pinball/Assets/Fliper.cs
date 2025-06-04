using UnityEngine;

public class Fliper : MonoBehaviour
{   
    public float forca = 2f;
    public Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(KeyCode.A)) && (gameObject.tag == "Esquerda")){
            
            rb.AddForce(new Vector2(0f, 1f)*forca,ForceMode2D.Impulse);
        }

          if ((Input.GetKey(KeyCode.D)) && (gameObject.tag == "Direita")){
            
            rb.AddForce(new Vector2(0f, 1f)*forca,ForceMode2D.Impulse);
        }
    }
}
