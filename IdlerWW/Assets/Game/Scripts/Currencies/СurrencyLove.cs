using UnityEngine;

public class ÑurrencyLove : Ñurrency
{
    private float _love;
    private void Start()
    {
        CurrencyUI.OnChangedLove(Read());
    }
    public override float Read()
    {
        return _love;
    }
    public override void Change(float change)
    {
        _love += change;
        if (_love < 0)
        {
            _love = 0;
            Debug.Log("0 Love");
        }
        CurrencyUI.OnChangedLove(Read());
    }
}
