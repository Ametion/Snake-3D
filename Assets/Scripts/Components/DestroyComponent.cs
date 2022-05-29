﻿using UnityEngine;

namespace Components
{
    public class DestroyComponent : MonoBehaviour
    {
        public void DestroySelf() => Destroy(gameObject);

        public void DestroyTarget(GameObject target) => Destroy(target);
    }
}