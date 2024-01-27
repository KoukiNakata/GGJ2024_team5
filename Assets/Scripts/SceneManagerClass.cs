using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// シーン遷移処理
/// </summary>
public class SceneManagerClass : MonoBehaviour
{
    public void SceneTransition(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}