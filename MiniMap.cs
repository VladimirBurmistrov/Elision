using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour
{
    public GameObject Target1;
    public GameObject Target2;
    private GameObject Target;
    public Transform Trans1;
    public Transform Trans2;
    private Transform Trans;
    public float distance = 100;

    void LateUpdate()
    {
        if (Target1.activeSelf)
        {
            Target = Target1;
            Trans = Trans1;
        }
        if (Target2.activeSelf)
        {
            Target = Target2;
            Trans = Trans2;
        }
        transform.position = Target.transform.position + Vector3.up * distance;
        transform.rotation = Quaternion.Euler(90, Trans.eulerAngles.y, 0);
    }
}
