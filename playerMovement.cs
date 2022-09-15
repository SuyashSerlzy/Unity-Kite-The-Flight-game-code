using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class playerMovement : MonoBehaviour
{
    public float speed;
    public float speed2 = 0.63f;
    public KeyCode down = KeyCode.DownArrow;
    public KeyCode up = KeyCode.UpArrow;
    void Update()
    {
            transform.Translate(Vector3.forward * speed / 3);
            float xDirection = Input.GetAxis("Horizontal");
            Vector3 moveDirection = new Vector3(xDirection, 0.0f, 0.0f);
            transform.position += moveDirection * speed2;
            if (Input.GetKey(down))
            {
                transform.Translate(Vector3.up * -speed2 / 4);
            }
            if (Input.GetKey(up))
            {
                transform.Translate(Vector3.up * speed2 / 4);
            }
    }
}
