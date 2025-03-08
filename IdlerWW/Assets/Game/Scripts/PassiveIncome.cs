using System.Collections;
using UnityEngine;
public class PassiveIncome : MonoBehaviour
{
    private float _passiveEnergyLife = 1;
    private const int _timeBetweenIncome = 1;
    private ÑurrencyEnergyOfLife _ñurrencyEnergyOfLife;
    private void Awake()
    {
        _ñurrencyEnergyOfLife = GetComponent<ÑurrencyEnergyOfLife>();
    }
    private void Start()
    {
        StartCoroutine(Income());
    }
    public void ChangePassiveEnergyLife(float change)
    {
        _passiveEnergyLife += change;
    }
    private IEnumerator Income()
    {
        yield return new WaitForSeconds(_timeBetweenIncome);
        _ñurrencyEnergyOfLife.Change(_passiveEnergyLife);
        StartCoroutine(Income());
    }
}
