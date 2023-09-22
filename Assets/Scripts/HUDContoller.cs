using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using StarterAssets;
using UnityEngine;
using UnityEngine.UI;

public class HUDContoller : MonoBehaviour
{
    [Header("Interface Elements")]
    [SerializeField] private Text battleChipsCount;

    [Header("Chip Selector")]
    [SerializeField] private GameObject chipFocus;
    [SerializeField] private GameObject[] chips;

    public int BattleChips
    {
        set
        {
            battleChipsCount.text = "Battle Chips: " + value;
        }
    }

    public ThirdPersonController.BattleChip Chip
    {
        set
        {
            chipFocus.transform.position = new UnityEngine.Vector3(
            chips[(int)value].transform.position.x,
            chipFocus.transform.position.y
        );
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
