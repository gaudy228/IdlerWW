using System.Collections;
using UnityEngine;
public class PassiveIncome : MonoBehaviour
{
    private float _passiveEnergyLife = 1;
    private float _passiveLove = 1;
    private const int _timeBetweenIncome = 1;
    private ÑurrencyEnergyOfLife _ñurrencyEnergyOfLife;
    private ÑurrencyLove _ñurrencyLove;
    private void Awake()
    {
        _ñurrencyEnergyOfLife = GetComponent<ÑurrencyEnergyOfLife>();
        _ñurrencyLove = GetComponent<ÑurrencyLove>();
    }
    private void Start()
    {
        StartCoroutine(Income());
    }
    public void ChangePassiveEnergyLife(float change)
    {
        _passiveEnergyLife += change;
    }
    public void ChangePassiveLove(float change)
    {
        _passiveLove += change;
    }
    private IEnumerator Income()
    {
        yield return new WaitForSeconds(_timeBetweenIncome);
        _ñurrencyEnergyOfLife.Change(_passiveEnergyLife);
        _ñurrencyLove.Change(_passiveLove);
        StartCoroutine(Income());
    }
}
