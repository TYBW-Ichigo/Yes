using UnityEngine;
using System.Collections;

public class DoorKey : MonoBehaviour
{

    public bool inTrigger;
    public AudioSource FoundKeyVoiceLine;

    void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
    }

    void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }

    void Update()
    {
        if (inTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                DoorScript.doorKey = true;
                Destroy(this.gameObject);
            }
        }
    }

    void OnGUI()
    {
        FoundKeyVoiceLine = GetComponent<AudioSource>();

        if (inTrigger)
        {
            GUI.Box(new Rect(0, 60, 200, 25), "Press E to take key");
            FoundKeyVoiceLine.Play();
        }
    }
}