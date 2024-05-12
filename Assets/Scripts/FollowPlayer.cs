using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 offset = new Vector3(0, 2f, -7);
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset ;
    }
}
