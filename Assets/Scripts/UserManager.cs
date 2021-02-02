using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UserManager : MonoBehaviour
{
    public GameObject userEntry;

    public Transform userList;

    private List<UserModel> users = new List<UserModel>();

    string URL = "http://localhost/ASM_NguyenVanQue_PS11150/index.php";

    // Use this for initialization
    void Start()
    {
        GetUser();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GetUser()
    {
        StartCoroutine(conectServer());
    }

    IEnumerator conectServer()
    {
        users.Clear();

        WWWForm wf = new WWWForm();

        WWW w = new WWW(URL, wf);

        yield return w;

        string data = w.text; // la chuoi 

        //Debug.Log (data);

        string[] a = new String[] { };

        a = data.Split(',');

        for (int i = 0; i < (a.Length) - 1; i++)
        {
            string dataUser = a[i];
            string[] b = new String[] { };
            b = dataUser.Split('-');
            users.Add(new UserModel(b[0], b[1], b[2], b[3],b[4]));
        }

        this.ShowUser();

    }

    public void ShowUser()
    {
        for (int i = 0; i < users.Count; i++)
        {
            if (i <= users.Count - 1)
            {


                GameObject g = (GameObject)Instantiate(userEntry);

                g.transform.SetParent(this.transform);

                UserModel tmpUser = users[i];


                g.transform.Find("ID").GetComponent<Text>().text = tmpUser.ID;
                g.transform.Find("TenTaiKhoan").GetComponent<Text>().text = tmpUser.TenTaiKhoan;
                g.transform.Find("MatKhau").GetComponent<Text>().text = tmpUser.MatKhau;
                g.transform.Find("Level").GetComponent<Text>().text = tmpUser.Level; // them de lieu cho text ID
                g.transform.Find("Diem").GetComponent<Text>().text = tmpUser.Diem;
            
            }
        }
    }
}
