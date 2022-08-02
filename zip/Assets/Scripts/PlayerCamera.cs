using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField]
    CinemachineVirtualCamera thirdPersonCam;
    [SerializeField]
    CinemachineVirtualCamera firstPersonCam;

    private void OnEnable()
    {
        CameraSwitch.Register(thirdPersonCam);
        CameraSwitch.Register(firstPersonCam);
        CameraSwitch.SwitchCamera(thirdPersonCam);
    }
    private void OnDisable()
    {
        CameraSwitch.UnRegister(thirdPersonCam);
        CameraSwitch.UnRegister(firstPersonCam);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (CameraSwitch.IsActiveCamera(thirdPersonCam))
            {
                CameraSwitch.SwitchCamera(firstPersonCam);
            }
            else if (CameraSwitch.IsActiveCamera(firstPersonCam))
            {
                CameraSwitch.SwitchCamera(thirdPersonCam);
            }
        }
    }
}
