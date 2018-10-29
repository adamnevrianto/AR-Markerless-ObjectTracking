using UnityEngine;
using UnityEngine.UI;

public class InfoScript : MonoBehaviour {

    private GameObject thisObject;
    private GameObject cameraPosition;
    Transform objectPosition;
    public Text objectText;

    string btnComponent;
    

	// Use this for initialization
	void Start () {
        cameraPosition = GameObject.Find("ARCamera");
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                Debug.Log("You selected the " + hit.transform.name); // ensure you picked right object
                btnComponent = hit.transform.name;
                thisObject = hit.transform.gameObject;

                switch (btnComponent)
                {
                    case "Mesh36":
                        objectText.text = "Atmega 328";
                        break;
                    case "Mesh63":
                        objectText.text = "USB type B socket";
                        break;
                    case "Mesh49":
                        objectText.text = "DC Barrel Power Jack";
                        break;
                    case "Mesh157":
                        objectText.text = "Quartz Crystal HC49U1";
                        break;
                    case "Mesh136":
                        objectText.text = "G 1x8 female pin header";
                        break;
                    case "Mesh48":
                        objectText.text = "G 1x6 female pin header";
                        break;
                    case "Mesh25":
                        objectText.text = "G 1x8 female pin header";
                        break;
                    case "Mesh158":
                        objectText.text = "G 1x8 female pin header";
                        break;
                    case "Mesh105":
                        objectText.text = "QFN PACKAGES";
                        break;
                    case "Mesh66":
                        objectText.text = "Quartz Crystal HC49U1";
                        break;
                    case "Mesh21":
                        objectText.text = "Power Switch";
                        break;
                    default:
                        break;
                }

            }
        }


        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("You selected the " + hit.transform.name); // ensure you picked right object
                btnComponent = hit.transform.name;
                thisObject = hit.transform.gameObject;

                switch (btnComponent)
                {
                    case "Mesh36":
                        objectText.text = "Atmega 328";
                        break;
                    case "Mesh63":
                        objectText.text = "USB type B socket";
                        break;
                    case "Mesh49":
                        objectText.text = "DC Barrel Power Jack";
                        break;
                    case "Mesh157":
                        objectText.text = "Quartz Crystal HC49U1";
                        break;
                    case "Mesh136":
                        objectText.text = "G 1x8 female pin header";
                        break;
                    case "Mesh48":
                        objectText.text = "G 1x6 female pin header";
                        break;
                    case "Mesh25":
                        objectText.text = "G 1x8 female pin header";
                        break;
                    case "Mesh158":
                        objectText.text = "G 1x8 female pin header";
                        break;
                    case "Mesh105":
                        objectText.text = "QFN PACKAGES";
                        break;
                    case "Mesh66":
                        objectText.text = "Quartz Crystal HC49U1";
                        break;
                    case "Mesh21":
                        objectText.text = "Power Switch";
                        break;
                    default:
                        break;
                }
            }
        }
	}
}
