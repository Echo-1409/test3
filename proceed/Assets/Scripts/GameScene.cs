using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScene : MonoBehaviour
{

    public void DoAThing(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }

}