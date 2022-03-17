using System.Collections;
using UnityEngine;

namespace DarkSalo.Infrastructure
{
    public interface ICoroutineRunner
    {
        Coroutine StartCoroutine(IEnumerator coroutine);
    }
}