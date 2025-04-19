using MelonLoader;
using UnityEngine;

[assembly: MelonInfo(typeof(SempreTitular.Main), "Sempre Titular", "1.0.0", "TeusNoob")]
[assembly: MelonGame(null, null)]

namespace SempreTitular
{
    public class Main : MelonMod
    {
        public override void OnApplicationStart()
        {
            MelonLogger.Msg("Mod Sempre Titular carregado com sucesso!");
        }
    }
}
