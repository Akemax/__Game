using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour
{
    public GameObject respaun;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Player")
        {
            SceneManager.LoadScene("Die");
        }
    }
}
