using System.Collections;
using UnityEngine;
public class PassiveIncome : MonoBehaviour
{
    private float _passiveEnergyLife = 1;
    private const int _timeBetweenIncome = 1;
    private �urrencyEnergyOfLife _�urrencyEnergyOfLife;
    private void Awake()
    {
        _�urrencyEnergyOfLife = GetComponent<�urrencyEnergyOfLife>();
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
        _�urrencyEnergyOfLife.Change(_passiveEnergyLife);
        StartCoroutine(Income());
    }
}
