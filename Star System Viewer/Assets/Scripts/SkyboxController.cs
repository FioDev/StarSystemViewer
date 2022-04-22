using UnityEngine;

[ExecuteAlways]
public class SkyboxController : MonoBehaviour
{
    [SerializeField] Transform _Pohsaidahs = default;

    [SerializeField] Transform _Gaiah = default;
    [SerializeField] Transform _Loonees = default;

    [SerializeField] Transform _Hohdjeeahn = default;
    [SerializeField] Transform _Haidjeeahs = default;
    [SerializeField] Transform _Djahnah = default;
    [SerializeField] Transform _Teldess = default;

    void LateUpdate()
    {
        // Directions are defined to point towards the object

        // Sun
        Shader.SetGlobalVector("_SunDirection", -_Pohsaidahs.transform.forward);

        // Moon
        Shader.SetGlobalVector("_MoonDirection", -_Gaiah.transform.forward);
        //Moons Moon
        Shader.SetGlobalVector("_MoonsMoonDirection", -_Loonees.transform.forward);

        //Jupiter
        Shader.SetGlobalVector("_JupiterDirection", -_Hohdjeeahn.transform.forward);
        //Mars
        Shader.SetGlobalVector("_MarsDirection", -_Haidjeeahs.transform.forward);
        //Venus
        Shader.SetGlobalVector("_VenusDirection", -_Djahnah.transform.forward);
        //Teldess
        Shader.SetGlobalVector("_TeldessDirection", -_Teldess.transform.forward);
    }
}