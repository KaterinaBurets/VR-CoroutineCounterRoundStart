using System.Collections;
using UnityEngine;
using TMPro;

public class GameHandler : MonoBehaviour
{
    [SerializeField] private InstantiateHandler _instantiateHandler;

    [SerializeField] private TextMeshProUGUI _secondsText;
    [SerializeField] private TextMeshProUGUI _roundText;
    [SerializeField] private TextMeshProUGUI _durationRoundText;

    private int _sec;
    private int _round = 0;
    private float _t = 10f;
    private bool _startRound = false;

    private void Update()
    {
        _secondsText.text = _sec.ToString();
        _roundText.text = _round.ToString();

        if (_startRound == true)
        {
            StopCoroutine(BeforeRoundCouroutine(5f));
            Invoke("CallArrayNull", _t);
            Timer();

            if (_t <= 0)
            {
                _t = 10f;
                _startRound = false;
            }
        }
        else
        {
            StartCoroutine(BeforeRoundCouroutine(5f));
            
        }
    }

    private void CallArrayNull()
    {
        _instantiateHandler.ArrayNull();
    }

    IEnumerator BeforeRoundCouroutine(float delay)
    {
        while (delay > 0)
        {
            _durationRoundText.text = $"До старта: {Mathf.Round(delay)} сек";
            yield return null;
            delay -= Time.deltaTime;
        }

        if (!_startRound)
        {
            _instantiateHandler.InstEnemy();
            _startRound = true;
            _round++;
        }
    }
    private float Timer()
    {
        _t -= Time.deltaTime;
        _sec = (int)_t;
        return _t;
    }
}