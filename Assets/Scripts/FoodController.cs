using System.Collections;
using UnityEngine;

namespace Components
{
    public class FoodController : MonoBehaviour
    {
        [SerializeField] private SpawnComponent _spawnComponent;

        private IEnumerator Start()
        {
            while (true)
            {
                yield return new WaitForSeconds(5f); 
                _spawnComponent.SpawnByRandomPositionInParent();
            }
        }
    }
}