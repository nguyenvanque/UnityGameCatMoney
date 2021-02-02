using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScences : MonoBehaviour
{
  //Loát màn hình theo vị trí Scenes
 public   void LoadScence(int index)
    {
        SceneManager.LoadScene(index);
    }

}
