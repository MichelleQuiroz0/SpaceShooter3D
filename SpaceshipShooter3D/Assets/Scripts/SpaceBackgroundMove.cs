using UnityEngine;

public class SpaceBackgroundMove : MonoBehaviour
{
    public float skyboxSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", skyboxSpeed * Time.time);
    }
}
