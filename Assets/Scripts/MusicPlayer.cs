using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    static MusicPlayer instance = null;

    void Awake () {
        if (instance != null) {
            Destroy(gameObject);
            print("Duplicate music player self-desructing");
        } else {
            instance = this;
        }
        GameObject.DontDestroyOnLoad(gameObject);
    }

    // Use this for initialization
    void Start() {

    }
    
    // Update is called once per frame
    void Update() {
        
    }
}

// TODO: 
// 1. Randomize playback
// 2. Pause and reactivate music when user pauses the game
// 3. Animate the music start.