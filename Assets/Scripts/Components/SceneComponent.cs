using UnityEngine;
using UnityEngine.SceneManagement;

namespace Components
{
    public class SceneComponent : MonoBehaviour
    {
        public void LoadScene(int sceneId) => SceneManager.LoadScene(sceneId);

        public void ReloadScene() => SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        public void ExitGame() => Application.Quit();
    }
}