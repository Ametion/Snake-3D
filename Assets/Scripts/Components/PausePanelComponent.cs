using Components.Model;
using UnityEngine;

namespace Components
{
    public class PausePanelComponent : MonoBehaviour
    {
        private GameSession _gameSession;

        private void Awake()
        {
            _gameSession = FindObjectOfType<GameSession>();
            _gameSession.PauseDataModel.IsPause = true;
        }

        public void ResumeGame() => _gameSession.PauseDataModel.IsPause = false;
    }
}