using UnityEngine;

public class DriverScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] float steerSpeed = 0.1f;
    [SerializeField] float moveSpeed = 10;
    [SerializeField] float boostSpeed = 20;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
     
        transform.Rotate(0,0,-steerAmount);
        transform.Translate(0,moveAmount,0);        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Boost") {
            moveSpeed = boostSpeed;
            if(other.tag == "Bump") {
                moveSpeed = 10;
            }
        } 

        if(other.tag == "Bump") {
            moveSpeed = 10;
            if(other.tag == "Boost") {
                moveSpeed = boostSpeed;
            }
        }
    }
}
