using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public System.Action onPlayerWon,onPLayerLost;
    public TextMeshProUGUI turnText;
    [SerializeField] private int _turnsLeft;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;

    }
    private void OnEnable()
    {
        turnText.text = _turnsLeft.ToString();
        PlayerMovementComponent.onPlayerMoved += reduceTurn;
    }
    private void OnDisable()
    {
        PlayerMovementComponent.onPlayerMoved -= reduceTurn;
    }
    private void reduceTurn()
    {
        _turnsLeft -= 1;
       if(_turnsLeft <= 0)
        {
            onPLayerLost?.Invoke();
        }
        turnText.text=_turnsLeft.ToString();    
    }

}
