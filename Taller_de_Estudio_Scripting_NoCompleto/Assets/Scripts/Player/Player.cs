using System.Collections;
using System.Linq;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region Variables
    [SerializeField] private float shootingForceMag = 50f, moveMag = 4f, reloadTime = 0.5f, rotationMag = 10f;
    private GameObject shootingPoint;
    private bool canShoot = true;
    private FoodEnum currentDeliciousProjectile;
    #endregion

    #region Private Functions
    private void Awake()
    {
        shootingPoint = transform.GetChild(0).gameObject;
    }

    private void Start()
    {
        currentDeliciousProjectile = FoodEnum.Meat;
    }
    #endregion

    #region Public Functions
    public void ExecuteMove(float zInput, float xInput)
    {
        Vector3 displacement = transform.forward * moveMag * zInput * Time.deltaTime 
            + transform.right * moveMag * xInput * Time.deltaTime;
        transform.position += displacement;
    }

    public void FireDeliciousWeapon()
    {
        if (canShoot)
        {
            canShoot = false;
            StartCoroutine(Reload());
            GameObject newProj = GetFoodProjectile(currentDeliciousProjectile);
            newProj.transform.position = shootingPoint.transform.position; 
            newProj.transform.rotation = Quaternion.identity;
            newProj.GetComponent<Rigidbody>().AddForce(shootingPoint.transform.forward * shootingForceMag, 
                ForceMode.Impulse);
        }
    }

    public void RotatePlayer(float yInput)
    {
        Vector3 totalRotation = transform.up * rotationMag * yInput * Time.deltaTime;
        transform.eulerAngles += totalRotation;
    }

    public GameObject GetFoodProjectile(FoodEnum foodKey)
    {
        //return RestaurantManager.Restaurant.GetIngredient(foodKey);
        return null;
    }

    public void ChangeFoodKeyEnum()
    {
        if(System.Enum.GetValues(currentDeliciousProjectile.GetType()).Cast<FoodEnum>().Max() > currentDeliciousProjectile)
        {
            currentDeliciousProjectile++;
        }
        else
        {
            currentDeliciousProjectile = 0;
        }
    }

    public IEnumerator Reload()
    {
        yield return new WaitForSeconds(reloadTime);
        canShoot = true;
    }
    #endregion
}