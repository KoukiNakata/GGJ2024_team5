using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;


/// <summary>
/// シーン遷移処理
/// </summary>
public class SceneManagerClass : MonoBehaviour
{
    public async void SceneTransition(string sceneName)
    {
        await Task.Delay(1000);
        SceneManager.LoadScene(sceneName);
    }
   
}