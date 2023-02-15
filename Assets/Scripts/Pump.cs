using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Pump : MonoBehaviour {
  [SerializeField]
  private Button _buttonSwing;
  [SerializeField]
  private Button _buttonNewBall;
  [SerializeField]
  private Ball scrBall;
  public float airQuantity;
  
  public void Swing() {
    if (scrBall.IsThereABall == true)
    {
      airQuantity = 1;
      scrBall.Chamber();
    }
  }
  public void NewBall() {
    if (scrBall.IsThereABall == false)
    {
      scrBall.gameObject.SetActive(true);
      scrBall.gameObject.transform.localScale = new Vector3(1, 1, 1);
      scrBall.IsThereABall = true;
    }
  }
}