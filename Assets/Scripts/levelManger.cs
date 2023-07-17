using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelManger : MonoBehaviour
{
  ///  public void LoadNextLevel()
  //  {
    //    int currentSceneindex = SceneManager.GetActiveScene().buildIndex;
      //  SceneManager.LoadScene(currentSceneindex + 1);
    //}
    public void LoadStart()
    {
        SceneManager.LoadScene(0);
    }
}
