using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadLevel(int a)
    {
        Application.LoadLevel(a);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
