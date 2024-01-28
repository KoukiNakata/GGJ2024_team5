using UnityEngine;
using System.Threading.Tasks;

public class quitGame : MonoBehaviour
{
    /// <summary>
    /// ゲームを終了する
    /// </summary>
    public async void quitaGame()
    {
        await Task.Delay(1000);
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;

#else
    Application.Quit();
#endif
    }
}
