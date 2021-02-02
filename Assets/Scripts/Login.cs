using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
	public InputField user, pass;
	public Button btnLogin;

	string loginPHP = "http://localhost/ASM_NguyenVanQue_PS11150/login.php";

    public void Login1()
	{
		StartCoroutine(conectServer());
	}

	public void Register()
	{
		SceneManager.LoadScene("SplashScenes");
	}

	IEnumerator conectServer()
	{
		WWWForm wf = new WWWForm();
		// gan du lieu tu textField vao PHP
		wf.AddField("TenTaiKhoan", user.text);
		wf.AddField("MatKhau", pass.text);

		// dua vao file PHP
		WWW w = new WWW(loginPHP, wf);

		yield return w;

		string MyName = w.text;

		if (MyName.Trim() == "success")
		{
			print("Login Successfully!");
			SceneManager.LoadScene("Begin");
		}
		else
		{
			print("Login Failed!");
		}
	}
}
