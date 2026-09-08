using UnityEngine;

public class movimento : MonoBehaviour
{
    float speed = 5F;
    float horizontal;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        transform.position += Vector3.right * horizontal * speed * Time.deltaTime;
        
    }
}
