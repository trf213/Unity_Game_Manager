using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public void loadLevel(int SceneIndex, Slider progressBar)
    {
      StartCoroutine(LoadAsync(SceneIndex, progressBar));
    }

    IEnumerator LoadAsync(int SceneIndex, Slider progressBar)
    {
         AsyncOperation operation = SceneManager.LoadSceneAsync(SceneIndex);
        while(!operation.isDone)
        { 
            float progress = Mathf.Clamp01(operation.progress/0.9f);
            progressBar.value = progress;
            yield return null;
        }
    }
}
