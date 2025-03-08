using UnityEngine;

public class GivenLove : MonoBehaviour
{
    [SerializeField] private ÑurrencyLove _ñurrencyLove;
    [SerializeField] private float _amountLoveGiven;
    public void AcceptingLove()
    {
        _ñurrencyLove.Change(_amountLoveGiven);
    }
}
