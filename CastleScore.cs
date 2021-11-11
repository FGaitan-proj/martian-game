using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleScore : MonoBehaviour
{
    [SerializeField] private Score scoreboard;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D mrtin){
      if (mrtin.gameObject.CompareTag("Martian")){
        scoreboard.score -= scoreboard.AttackPower;
      }
    }
}
