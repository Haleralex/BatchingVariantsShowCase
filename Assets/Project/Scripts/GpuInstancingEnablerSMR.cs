using UnityEngine;
using UnityEngine.Rendering;

namespace Project.Scripts
{
    [RequireComponent(typeof(SkinnedMeshRenderer))]
    public class GpuInstancingEnablerSMR : MonoBehaviour
    {
        private void Awake()
        {
            MaterialPropertyBlock materialPropertyBlock = new();
            var meshRenderer = GetComponent<SkinnedMeshRenderer>();
            meshRenderer.SetPropertyBlock(materialPropertyBlock);
        }
    }
}