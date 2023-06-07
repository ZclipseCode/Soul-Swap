using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedWeaponTrackingPlayer : MonoBehaviour
{
    [SerializeField] float followSpeed = 4;
    [SerializeField] Transform followTarget;
    [SerializeField] Transform lookTarget;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //weapon to follow player
        transform.position = Vector3.Lerp(transform.position, followTarget.position, followSpeed * Time.deltaTime);

        //weapon to aim in right direction
        transform.right = lookTarget.position - transform.position;
    }
}
