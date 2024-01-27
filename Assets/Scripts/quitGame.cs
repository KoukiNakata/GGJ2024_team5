using UnityEngine;

public class quitGame : MonoBehaviour
{
    /// <summary>
    /// ゲームを終了する
    /// </summary>
    public void quitaGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif
    }
}
