using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MartainSpawnScr : MonoBehaviour
{
    public Sprite[] Martians = new Sprite[5];
    [SerializeField] private Score scoreboard;
    [SerializeField] private GameObject MartianPrefab;
    [SerializeField] private GameObject CastleDoor;
    [SerializeField] private SpriteRenderer sprR;
    // Start is called before the first frame update
    void Start()
    {
      sprR = MartianPrefab.GetComponent<SpriteRenderer>();
      Instantiate(MartianPrefab, transform.position, Quaternion.identity);
      scoreboard.Martians--;
      Invoke("SpawnRepeat",Random.Range(0,3));

    }
    void Update(){
      if (scoreboard.Martians == 0){
        Vector3 martpos = MartianPrefab.transform.position;
        Vector3 castlepos = CastleDoor.transform.position;
        float dist = Vector3.Distance(martpos,castlepos);
        float speed =  MartianPrefab.GetComponent<MartianScript>().speed;
        Invoke("GameOver", (dist / speed) * Time.deltaTime);
      } else {
          scoreboard.score++;
      }
    }
    void GameOver(){
      Debug.Log("GameOver!");
    }
    void SpawnRepeat()
    {
      var j = scoreboard.Martians;
      for (var i = 0; i < j; i++){
        Invoke("RandomMartian",i);
      }

    }
    void RandomMartian()
    {
      var x = Random.Range(0,4);
      var y = Random.Range(2.0f,scoreboard.DistancebMart);
      for (var i = 0; i < 5; i++){
        if (i == x){
          sprR.sprite = Martians[i];
          Invoke("SpawnMartian",y);

        }
        }
    }
    void SpawnMartian(){
      Instantiate(MartianPrefab, transform.position, Quaternion.identity);
      scoreboard.Martians--;
    }
}
