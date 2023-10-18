using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSceneManager : MonoBehaviour
{
    public int nextSceneIndex; // Define the next scene in the build index through the Unity Inspector
    public EndSceneTrigger[] endSceneTriggers; // An array of EndSceneTrigger objects

    private void Start()
    {
        // Initialize the array of triggers through FindObjectsOfType to find all active instances
        endSceneTriggers = FindObjectsOfType<EndSceneTrigger>();
    }

    private void Update()
    {
        if (AllTriggersDetected())
        {
            LoadNextScene();
        }
    }

    // Check if all triggers have detected set to true
    private bool AllTriggersDetected()
    {
        foreach (EndSceneTrigger trigger in endSceneTriggers)
        {
            if (!trigger.detected)
            {
                return false; // If any trigger is not detected, return false
            }
        }
        return true; // All triggers have detected set to true
    }

    // Load the next scene
    private void LoadNextScene()
    {
        //SceneManager.LoadScene(nextSceneIndex);
        Debug.Log("Loading Scene with Index :" +  nextSceneIndex);
    }
}
