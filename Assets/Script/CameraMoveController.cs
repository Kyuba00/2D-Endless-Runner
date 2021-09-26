using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveController : MonoBehaviour
{
    [Header("Position")]
    public Transform player;
    public float horizontalOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        //kamera digerakan dengan mengambil posisi player
        //dan mengkalkulasikannya dengan offset posisi kamera yang diinginkan
        Vector3 newPosition = transform.position;
        newPosition.x = player.position.x + horizontalOffset;
        transform.position = newPosition;
    }
}
