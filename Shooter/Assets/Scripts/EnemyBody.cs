using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyBody : MonoBehaviour
{
    public string LevelToLoad = "";

    // Start is called before the first frame update
    void Start()
    {
        if (LevelToLoad == "") // default to current scene 
        {
            LevelToLoad = Application.loadedLevelName;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "SpaceShip")
        {
            Destroy(other);
            SceneManager.LoadScene(LevelToLoad);
        }
        else if (other.name == "Rocket")
        {

        }
    }
}
