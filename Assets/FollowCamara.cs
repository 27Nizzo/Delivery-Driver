using UnityEngine;

public class FollowCamara : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3(0,0,-1.33f);         
    }
}
