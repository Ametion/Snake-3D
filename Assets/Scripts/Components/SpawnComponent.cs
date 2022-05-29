using UnityEngine;

namespace Components
{
    public class SpawnComponent : MonoBehaviour
    {
        [SerializeField] private GameObject _prefab;
        [SerializeField] private Transform _parent;
        
        public void SpawnInParent() => Instantiate(_prefab, _parent);

        public void SpawnByRandomPositionInParent() =>
            Instantiate(_prefab, new Vector3(Random.Range(-18, 18), 0.5f, Random.Range(-18, 18)), _prefab.transform.rotation, _parent);
    }
}