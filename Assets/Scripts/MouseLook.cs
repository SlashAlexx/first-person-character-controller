using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float look_sensitivity = 100f;
    public Transform player_body;
    float x_rotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Locks cursor to the center of the game view
    }

    void Update()
    {
        float mouse_position_x = Input.GetAxis("Mouse X") * look_sensitivity * Time.deltaTime;
        float mouse_position_y = Input.GetAxis("Mouse Y") * look_sensitivity * Time.deltaTime;

        x_rotation -= mouse_position_y;
        x_rotation = Mathf.Clamp(x_rotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(x_rotation, 0, 0);
        player_body.Rotate(Vector3.up * mouse_position_x);
    }
}
