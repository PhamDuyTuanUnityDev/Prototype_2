using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float delay = 0f;
    public float timeRate = 1f;

    // Update is called once per frame
    void Update()
    {
        delay += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && delay >= timeRate)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            delay = 0f;
        }
    }
}
