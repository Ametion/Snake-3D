using UnityEngine;
using UnityEngine.Events;

namespace Components
{
    public class OnTriggerComponent : MonoBehaviour
    {
        [SerializeField] private string _tag;
        [SerializeField] private UnityEvent _action;

        private void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.CompareTag(_tag))
                _action?.Invoke();
        }
    }
}