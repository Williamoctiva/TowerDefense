/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAT : MonoBehaviour
{
    public Camera my_camera;

    // Update is called once per frame
    void LateUpdate()
    {
        // Check if my_camera is assigned before using it
        if (my_camera != null)
        {
            // Calculate the target position using camera's rotation
            Vector3 targetPosition = transform.position + my_camera.transform.rotation * Vector3.back;

            // Make the current object look at the target position
            transform.LookAt(targetPosition, my_camera.transform.rotation * Vector3.up);
        }
        else
        {
            Debug.LogWarning("Camera reference in LookAT script is not assigned!");
        }
    }
}
*/
using System.Collections;
using UnityEngine;


public class LookAT : MonoBehaviour
{
   public Camera my_camera;

    
    void Update()
    {
        if (my_camera != null)
        {
        transform.LookAt (transform.position + my_camera.transform.rotation * Vector3.back,
        my_camera.transform.rotation * Vector3.up);
        }
        else
        {
            Debug.LogWarning("Camera reference is missing in LookAt script.");
        }
        
    }
}
/*using System.Collections;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Camera my_camera;

    void Update()
    {
        if (my_camera != null)
        {
            // Calculate the direction from this object to the camera
            Vector3 lookDirection = my_camera.transform.position - transform.position;

            // Ensure the object faces the camera's position
            transform.rotation = Quaternion.LookRotation(lookDirection, Vector3.up);
        }
        else
        {
            Debug.LogWarning("Camera reference is missing in LookAt script.");
        }
    }
}*/



