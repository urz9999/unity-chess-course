using UnityEngine;

// This is a simple class that shows how to programmatically assign a material to an object via the mesh renderer property
[RequireComponent(typeof(MeshRenderer))]
public class MaterialSetter : MonoBehaviour
{
	private MeshRenderer _meshRenderer;
	private MeshRenderer meshRenderer
	{
		get
		{
			if (_meshRenderer == null)
				_meshRenderer = GetComponent<MeshRenderer>();
			return _meshRenderer;
		}
	}

	public void SetSingleMaterial(Material material)
	{
		meshRenderer.material = material;
	}
}