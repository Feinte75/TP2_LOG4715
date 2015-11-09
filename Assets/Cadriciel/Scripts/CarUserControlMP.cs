using UnityEngine;

[RequireComponent(typeof(CarController))]
public class CarUserControlMP : MonoBehaviour
{
	private CarController car;  // the car controller we want to use

	[SerializeField]
	private string vertical = "Vertical";

	[SerializeField]
	private string horizontal = "Horizontal";

	private bool nitro = false;
	private bool jump = false;

	void Awake ()
	{
		// get the car controller
		car = GetComponent<CarController>();
	}
	
	
	void FixedUpdate()
	{
		// pass the input to the car!
		#if CROSS_PLATFORM_INPUT
		float h = CrossPlatformInput.GetAxis(horizontal);
		float v = CrossPlatformInput.GetAxis(vertical);
		if (Input.GetKeyDown("space")) {
			car.GetComponent<CarStatus>().LaunchPowerUp();
		}

		nitro = Input.GetKey(KeyCode.LeftShift);		

		car.GetComponent<CarStatus>().ConsumeNitro(nitro);

		jump = Input.GetKey(KeyCode.LeftControl);

		car.GetComponent<CarStatus>().Jump(jump);

		#else
		float h = Input.GetAxis(horizontal);
		float v = Input.GetAxis(vertical);
		#endif
		car.Move(h,v);
	}
}
