using System.Collections;
using UnityEngine;
public class GeneratingLoveFromTheCharacters : MonoBehaviour
{
    [SerializeField] private float _timeBetweenSpawnLove;
    [SerializeField] private GameObject _panelWithLove;
    private bool _inCoroutine = false;
    private void Start()
    {
        StartCoroutine(IntervalBetweenSpawnLove());
    }
    private void Update()
    {
        if (!_panelWithLove.activeSelf && !_inCoroutine)
        {
            StartCoroutine(IntervalBetweenSpawnLove());
            _inCoroutine = true;
        }
    }
    private IEnumerator IntervalBetweenSpawnLove()
    {
        yield return new WaitForSeconds(_timeBetweenSpawnLove);
        _panelWithLove.SetActive(true);
        _inCoroutine = false;
    }
}
