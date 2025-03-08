using System.Collections;
using UnityEngine;
public class PassiveIncome : MonoBehaviour
{
    private float _passiveEnergyLife = 1;
    private float _passiveLove = 1;
    private const int _timeBetweenIncome = 1;
    private �urrencyEnergyOfLife _�urrencyEnergyOfLife;
    private �urrencyLove _�urrencyLove;
    private void Awake()
    {
        _�urrencyEnergyOfLife = GetComponent<�urrencyEnergyOfLife>();
        _�urrencyLove = GetComponent<�urrencyLove>();
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
        _�urrencyEnergyOfLife.Change(_passiveEnergyLife);
        _�urrencyLove.Change(_passiveLove);
        StartCoroutine(Income());
    }
}
