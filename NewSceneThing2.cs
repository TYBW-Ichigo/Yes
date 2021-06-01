using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NewSceneThing2 : MonoBehaviour
{

    private void OnTriggerEnter(Collider collider)
    {
        SceneManager.LoadScene(0);
    }
    
}