using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public System.Action onPlayerWon,onPLayerLost;
    private TextMeshProUGUI turnText;
    [SerializeField] private int _turnsLeft;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
        turnText=GameObject.FindGameObjectWithTag("turnText").GetComponent<TextMeshProUGUI>();
        
    }
    private void OnEnable()
    {
        turnText.text = _turnsLeft.ToString();
        PlayerMovementComponent.onPlayerMoved += reduceTurn;
        onPLayerLost += playerLostMessage;
    }
    private void OnDisable()
    {
        PlayerMovementComponent.onPlayerMoved -= reduceTurn;
        onPLayerLost -= playerLostMessage;
    }
    private void reduceTurn()
    {
        _turnsLeft -= 1;
       if(_turnsLeft <= 0)
        {
            _turnsLeft = 0;
            Debug.Log("lost Turn");
            onPLayerLost?.Invoke();
        }
        turnText.text=_turnsLeft.ToString();    
    }
    private void playerLostMessage()
    {
        Debug.Log("Player Lostttttt");
    }

}
