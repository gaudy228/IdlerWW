using System;
using TMPro;
using UnityEngine;

public class CurrencyUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _energyOfLifeText;
    [SerializeField] private TextMeshProUGUI _loveText;
    public static Action<float> OnChangedEnergyOfLife;
    public static Action<float> OnChangedLove;
    private void OnEnable()
    {
        OnChangedEnergyOfLife += ChangeEnergyOfLife;
        OnChangedLove += ChangeLove;
    }
    private void OnDisable()
    {
        OnChangedEnergyOfLife += ChangeEnergyOfLife;
        OnChangedLove -= ChangeLove;
    }
    private void ChangeEnergyOfLife(float energyOfLife)
    {
        _energyOfLifeText.text = energyOfLife.ToString("0");
    }
    private void ChangeLove(float love)
    {
        _loveText.text = love.ToString("0");
    }

}
