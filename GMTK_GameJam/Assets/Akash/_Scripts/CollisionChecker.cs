using UnityEngine;

public class CollisionChecker : MonoBehaviour
{
   
   public System.Action<Face,NumberPlate> OnCollisionWithNumberPlate;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered Trigger");
        if (other.gameObject.TryGetComponent<NumberPlate>(out NumberPlate num))
        {
            Face temp = this.gameObject.GetComponent<Face>();
            OnCollisionWithNumberPlate?.Invoke(temp, num);
           

        }
    }
}
