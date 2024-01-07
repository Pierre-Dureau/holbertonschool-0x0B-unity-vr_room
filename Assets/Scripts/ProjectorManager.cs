using UnityEngine;

public class ProjectorManager : MonoBehaviour
{
    [SerializeField] private GameObject _particleSystem;
    private bool isParticleActive = false;

    public void ParticleActivation() {
        if (isParticleActive)
            _particleSystem.SetActive(false);
        else
            _particleSystem.SetActive(true);
        isParticleActive = !isParticleActive;
    }
}
