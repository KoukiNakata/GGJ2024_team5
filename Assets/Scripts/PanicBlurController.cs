using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PanicBlurController : MonoBehaviour
{
    public PanicPointManager PPM;
    public PostProcessVolume ppVolume;
    public PostProcessProfile ppProfile;
    public Vignette vignetee;
    // Start is called before the first frame update
    void Start()
    {
        ppVolume = GetComponent<PostProcessVolume>();
        ppProfile = ppVolume.profile;
        vignetee =ppProfile.GetSetting<Vignette>();
        vignetee.enabled.Override(true);
        vignetee.intensity.Override(0f);
        vignetee.smoothness.Override(1f);
        vignetee.smoothness.Override(1f);
      

    }

    // Update is called once per frame
    void Update()
    {
        float parPP=PPM.panicPoint/PPM.panicPointMax;

        vignetee.intensity.Override(parPP);
        //Debug.Log(parPP);
    }
}
