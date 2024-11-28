using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class botonEleccion : MonoBehaviour
{
    // Start is called before the first frame update
    public void feelit()
    {
        SceneManager.LoadScene(2);
        Debug.Log("ir a feelit");
    }
    public void heylover()
    {
        SceneManager.LoadScene(3);
        Debug.Log("ir a hey lover");
    }
    public void humble()
    {
        SceneManager.LoadScene(4);
        Debug.Log("ir a humble");
    }
    public void letitrock()
    {
        SceneManager.LoadScene(5);
        Debug.Log("ir a let it rock");
    }
    public void technologic()
    {
        SceneManager.LoadScene(6);
        Debug.Log("ir a technologic");
    }

}