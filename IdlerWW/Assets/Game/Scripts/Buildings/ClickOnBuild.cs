using Cinemachine;
using System.Collections;
using UnityEngine;

public class ClickOnBuild : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera _cameraOnBuild;
    [SerializeField] private CinemachineVirtualCamera _cameraOnGeneralPlan;
    [SerializeField] private GameObject Panel;
    [SerializeField] private float _timeMovingToGeneralCamera;
    [SerializeField] private float _timeMovingToBuild;
    private bool _onBuild = false;
    private static bool _onOtherBuild = false;
    private static bool _cameraMoving = false;
    private void OnMouseDown()
    {
        if (_onBuild && !_cameraMoving)
        {
            _cameraOnGeneralPlan.gameObject.SetActive(true);
            _cameraOnBuild.gameObject.SetActive(false);
            Panel.SetActive(false);
            _onBuild = false;
            _onOtherBuild = false;
            StartCoroutine(MovingCamera(_timeMovingToGeneralCamera));
        }
        else if(!_cameraMoving && !_onOtherBuild)
        {
            _cameraOnBuild.gameObject.SetActive(true);
            _cameraOnGeneralPlan.gameObject.SetActive(false);
            _onBuild = true;
            _onOtherBuild = true;
            StartCoroutine(MovingCamera(_timeMovingToBuild));
        }
    }
    private IEnumerator MovingCamera(float timeMoving)
    {
        _cameraMoving = true;
        yield return new WaitForSeconds(timeMoving);
        if (_onBuild)
        {
            Panel.SetActive(true);
        }
        _cameraMoving = false;
    }
}
