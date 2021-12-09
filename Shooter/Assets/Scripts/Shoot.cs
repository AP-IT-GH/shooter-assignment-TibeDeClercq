using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float timer = 10f;
    bool start = false;
    public float shootRate = 1f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && timer >= shootRate)
        {
            GameObject newProjectile = Instantiate(projectile, transform.position + transform.forward + new Vector3(0,0,0), transform.rotation);
            newProjectile.GetComponent<Rigidbody>().AddForce(transform.forward * 60, ForceMode.VelocityChange);
            timer = 0f;
            start = true;
        }

        if (start)
        {
            if (timer < shootRate)
            {
                timer += Time.deltaTime;
            }
            else
            {
                timer = shootRate;
                start = false;
            }
        }
    }

    private void FixedUpdate()
    {
        
    }
}
