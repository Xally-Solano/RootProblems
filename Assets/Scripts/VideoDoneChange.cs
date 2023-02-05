using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoDoneChange : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    //public string nextSceneName;

    void Start()
    {
        videoPlayer.loopPointReached += LoadNextScene;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadNextScene(VideoPlayer vp)
    {
        SceneManager.LoadScene("MAIN_MENU");
    }

}

