using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameraaa : MonoBehaviour
{
    public Transform player;

    void Update()
    {
        transform.position = player.transform.position;
    }
}
 
