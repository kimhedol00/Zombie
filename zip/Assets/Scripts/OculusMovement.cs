using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVR;

public class OculusMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody playerRigidbody; // 플레이어 캐릭터의 리지드바디
    public float speed = 5.0f;

    void Update()
    {
        var joystickAxis = OVRInput.Get(OVRInput.RawAxis2D.LThumbstick, OVRInput.Controller.LTouch);
        float fixedY = playerRigidbody.position.y;

        playerRigidbody.position += (transform.right * joystickAxis.x + transform.forward * joystickAxis.y) * Time.deltaTime * speed;
        playerRigidbody.position = new Vector3(playerRigidbody.position.x, fixedY, playerRigidbody.position.z);
    }

}
