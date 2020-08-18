using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowThePlayer : MonoBehaviour
{
    public Transform player;
    private Vector3 offset = new Vector3(6,2,0);
    void Update()
    {
        transform.position = player.position+offset;
    }
}
