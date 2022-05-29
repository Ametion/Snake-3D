using UnityEngine;

namespace Components.Model
{
    public class GameSession : MonoBehaviour
    {
        [SerializeField] private PauseDataModel _pauseDataModel;
        public PauseDataModel PauseDataModel => _pauseDataModel;

        private void Awake()
        {
            if (IsSessionExit())
            {
                DestroyImmediate(gameObject);
            }
            else
            {
                DontDestroyOnLoad(this);
            }
        }

        private bool IsSessionExit()
        {
            var sessions = FindObjectsOfType<GameSession>();
            foreach (var gameSession in sessions)
            {
                if (gameSession != this)
                    return true;
            }

            return false;
        } 
    }
}