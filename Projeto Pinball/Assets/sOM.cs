using UnityEngine;

public class sOM : MonoBehaviour
{
    public AudioSource audio;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag=="Player")
        {
            audio.Play();
        }
    }
}
