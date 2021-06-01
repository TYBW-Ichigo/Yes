using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NewSceneThing1 : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(4);
    }
    
}