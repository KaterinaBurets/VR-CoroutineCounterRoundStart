using UnityEngine;
using TMPro;

public class CountHandler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _secondsText;
    [SerializeField] private TextMeshProUGUI _roundText;

    private int _sec;
    private int _round;

    public int Sec => _sec;
    public int Round => _round;

    private void Start()
    {
        _sec = 5;
        _round = 1;
    }
    private void Update()
    {
        _secondsText.text = _sec.ToString();
        _roundText.text = _round.ToString();
    }
}
