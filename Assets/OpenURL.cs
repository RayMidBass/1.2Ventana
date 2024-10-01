using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkWeb : MonoBehaviour
{
     public void OpenURL(string Urlname)
    {
        Application.OpenURL(Urlname);
        Debug.Log("is this working");
    }
 }