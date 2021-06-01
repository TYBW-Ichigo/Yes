using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NewSceneThing : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(3);
    }
    
}