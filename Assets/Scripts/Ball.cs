using UnityEngine;
public class Ball : MonoBehaviour {
  [SerializeField]
  private Pump scrPump;
  public bool IsThereABall = true;
  private float atmosphere = 0.5f;

  public void Chamber() {
    if (scrPump.airQuantity == 1) {
      gameObject.transform.localScale += new Vector3(atmosphere,atmosphere,atmosphere);
      scrPump.airQuantity = 0;

      if (gameObject.transform.localScale.x >= 4) {
        IsThereABall = false;
        Debug.Log(IsThereABall);
        gameObject.SetActive(false);
      }
    }
  }
}