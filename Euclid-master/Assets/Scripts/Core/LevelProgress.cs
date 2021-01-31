using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelProgress : MonoBehaviour
{

    // set as public variable in Editor
    // usually 0 for first level
    // 1 for target level

    public int levelIndexToLoad;

    public void OnTriggerEnter(Collider cTrigger)
    {

        // the Editor automatically offers the tag "Player" for GameObjects
        // if the trigger object is not tagged as Player, ignore it

        if (cTrigger.tag == "Player")
        {

            SceneManager.LoadScene(levelIndexToLoad);
        }
    }
}
