using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefillStation : MonoBehaviour
{
    [SerializeField] FPSController player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        player.AddInteractListener(RefillAmmo);
    }

    void OnTriggerExit(Collider other)
    {
        player.RemoveInteractListener(RefillAmmo);
    }

    void RefillAmmo()
    {
        player?.IncreaseAmmo(999);
    }
}
