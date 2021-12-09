using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCrit : MonoBehaviour
{
    public string LevelToLoad = "";
    // Start is called before the first frame update
    void Start()
    {
        if (LevelToLoad == "") // default to current scene 
        {
            LevelToLoad = "Scene 1";
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Rocket")
        {
            Destroy(transform.parent.gameObject);
            Points.points++;
        }
        else
        {
            Destroy(other);
            SceneManager.LoadScene(LevelToLoad);
        }
    }
}
