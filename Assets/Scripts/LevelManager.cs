using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    void Start() {
        Initialize();
    }

    public void Initialize() {
        Scene activeScene = SceneManager.GetActiveScene();
        _activeSceneBuildIndex = activeScene.buildIndex;
        Debug.Log("Active scene: " + _activeSceneBuildIndex);
    }

    public void LoadLevel(string name) {
        Debug.Log("Level load requested for: " + name);
        SceneManager.LoadSceneAsync(name);
    }

    public void QuitRequest() {
        Debug.Log("Game quit requested");
        Application.Quit();
    }

    private int _activeSceneBuildIndex = 0;

    public void LoadNextLevel() {
        Debug.Log("Loading next level based on index: " + (_activeSceneBuildIndex + 1));
        SceneManager.LoadSceneAsync(_activeSceneBuildIndex + 1);
    }
}
