using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }
    
}
