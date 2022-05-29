using UnityEngine;
using UnityEngine.UI;

namespace Components
{
    public class ScoreComponent : MonoBehaviour
    {
        [SerializeField] private Text _scoreText;
        
        private int _score;

        public void ChangeScore(int modifiedScore)
        {
            if(_score >= 0)
                _score += modifiedScore;

            _scoreText.text = _score.ToString();
        }

    }
}