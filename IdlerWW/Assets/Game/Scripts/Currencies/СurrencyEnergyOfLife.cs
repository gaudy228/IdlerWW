using UnityEngine;
public class ÑurrencyEnergyOfLife : Ñurrency
{
    private float _energyOfLife = 100;
    private void Start()
    {
        CurrencyUI.OnChangedEnergyOfLife(Read());
    }
    public override float Read()
    {
        return _energyOfLife;
    }
    public override void Change(float change)
    {
        _energyOfLife += change;
        if (_energyOfLife < 0)
        {
            _energyOfLife = 0;
            Debug.Log("0 Energy");
        }
        CurrencyUI.OnChangedEnergyOfLife(Read());
    }
}
