using UnityEngine;

public class GivenLove : MonoBehaviour
{
    [SerializeField] private �urrencyLove _�urrencyLove;
    [SerializeField] private float _amountLoveGiven;
    public void AcceptingLove()
    {
        _�urrencyLove.Change(_amountLoveGiven);
    }
}
