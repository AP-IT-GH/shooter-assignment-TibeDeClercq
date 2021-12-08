using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_follow : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        if (target == null)
        {
            target = this.gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            this.transform.localPosition = target.transform.localPosition + new Vector3(0,4,-10);
            this.transform.localRotation =  target.transform.localRotation;
        }
    }
}
