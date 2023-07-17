using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MangerScene : MonoBehaviour
{

    MangeHealth mangeHealth;
    private void Start()
    {
        mangeHealth = FindObjectOfType<MangeHealth>();
    }
    private void Update()
    {
        LoadNextLevel();
    }
    public void LoadNextLevel()
    {
        
        if (mangeHealth.health == 0)
        {
          //  Debug.Log(mangeHealth.health);
            int currentSceneindex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneindex + 1);
        }
      
    }
   
}
