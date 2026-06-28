using UnityEngine;
using UnityEngine.SceneManagement;

namespace PhiKiemSongHanh.Core
{
    public class GameSceneLoader : MonoBehaviour
    {
        public void LoadScene(string sceneName)
        {
            if (string.IsNullOrWhiteSpace(sceneName))
            {
                Debug.LogWarning("[GameSceneLoader] Scene name is empty.", this);
                return;
            }

            SceneManager.LoadScene(sceneName);
        }
    }
}
