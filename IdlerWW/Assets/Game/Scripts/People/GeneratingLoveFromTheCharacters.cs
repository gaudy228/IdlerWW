using System.Collections;
using UnityEngine;
public class GeneratingLoveFromTheCharacters : MonoBehaviour
{
    [SerializeField] private float _timeBetweenSpawnLove;
    [SerializeField] private GameObject _panelWithLove;
    private void Start()
    {
        StartCoroutine(IntervalBetweenSpawnLove());
    }
    private IEnumerator IntervalBetweenSpawnLove()
    {
        yield return new WaitForSeconds(_timeBetweenSpawnLove);
        _panelWithLove.SetActive(true);
        StartCoroutine(IntervalBetweenSpawnLove());
    }
}
