using System.Collections;
using System.Collections.Generic;
using System.Data;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class AimController : NetworkBehaviour
{
    [SerializeField] private Transform bodyAim;
    [SerializeField] private Transform aim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bodyAim.GetComponent<MultiAimConstraint>();
        aim.GetComponent<MultiAimConstraint>();    }
}
