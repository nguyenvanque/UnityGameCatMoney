using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    // phương thức thoát game khi người dùng nhấn vào nút thoát
    public void ExitGameMario()
    {
#if UNITY_EDITOR
        // lệnh thoát khi text trên unity
        UnityEditor.EditorApplication.isPlaying = false;
#else
// lệnh thoát khi chạy trên thiết bị thật
  Application.Quit();
#endif


    }
}
