using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputDetectpr : MonoBehaviour
{
    public string nextScene;
    
    void Update()
    {
        if(Input.anyKey) SceneManager.LoadScene(nextScene);
    }
}
