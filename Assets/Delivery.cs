using UnityEngine;

public class Delivery : MonoBehaviour
{
    // Default = false
    bool hasPackage;
    [SerializeField] Color32 hasPackageColor = new Color32(14,255,0,255);
    [SerializeField] Color32 noPackageColor = new Color32(1,1,1,1);
    [SerializeField] float destroyDelay = 0.5f; 


    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); 
    } 


    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Ah!");   
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Package" && !hasPackage) {
            Debug.Log("Package Taken");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);
        }

        if(other.tag == "Destiny" && hasPackage) {
            Debug.Log("Package Delivered");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }


}
