using UnityEngine;

[CreateAssetMenu(fileName = "MaterialPersonalizado", menuName = "Materiales/Personalizado")]
public class MaterialPersonalizado : ScriptableObject
{
    public Color colorBase;
    public float brillo;
    public float rugosidad;

    public event System.Action<MaterialPersonalizado> onChange;

    private Material material;

    public Material Material
    {
        get
        {
            if (material == null)
            {
                material = new Material(Shader.Find("Standard"));
                material.SetColor("_Color", colorBase);
                material.SetFloat("_Glossiness", brillo);
                material.SetFloat("_Metallic", rugosidad);
            }
            return material;
        }
    }

    public void ActualizarPropiedades()
    {
        if (material != null)
        {
            material.SetColor("_Color", colorBase);
            material.SetFloat("_Glossiness", brillo);
            material.SetFloat("_Metallic", rugosidad);
        }
        onChange?.Invoke(this);
    }
}