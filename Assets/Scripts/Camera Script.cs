using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform myPlayerTransform;
    public bool cameraLocked;
    public float panBorderThickness;
    public float panSpeed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            cameraLocked = !cameraLocked;
        }
        if (cameraLocked)
        {
            transform.position = myPlayerTransform.position + Vector3.back * 10;
        }
        else
        {
          Vector3 pos = transform.position;
            if (Input.mousePosition.y > Screen.height - panBorderThickness)
            {
                pos.y += panSpeed * Time.deltaTime;
            }
            if (Input.mousePosition.y <= panBorderThickness)
            {
                pos.y -= panSpeed * Time.deltaTime;
            }
            if (Input.mousePosition.x > Screen.width - panBorderThickness)
            {
                pos.x += panSpeed * Time.deltaTime;
            }
            if (Input.mousePosition.x <= panBorderThickness)
            {
                pos.x -= panSpeed * Time.deltaTime;
            }
            transform.position = pos;
        }
    }
}
