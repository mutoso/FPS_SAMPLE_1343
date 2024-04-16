using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraShake : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera virtualCamera;
    [SerializeField] bool shakeEnable = false;

    float elapsedTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        virtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (shakeEnable)
        {
            elapsedTime += Time.deltaTime;
            if (elapsedTime > 0.0f && elapsedTime <= 1.0f)
            {
                virtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 1.0f;
            }
            else
            {
                virtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 0.0f;
                elapsedTime = 0.0f;
                shakeEnable = false;
            }
        }
    }

    public void SetShakeEnable(bool enable)
    {
        shakeEnable = enable;
    }
}
