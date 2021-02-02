using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadCurentScenes : MonoBehaviour
{

    public void LoadScence(int index)
    {
        SceneManager.LoadScene(index);
    }
     }


