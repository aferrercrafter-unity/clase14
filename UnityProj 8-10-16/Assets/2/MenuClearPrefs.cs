using UnityEngine;
using UnityEditor;

public class MenuClearPrefs
{
	[MenuItem("GameObject/Borrar Player Prefs")]
	private static void ClearPlayerPrefs()
	{
		PlayerPrefs.DeleteAll();
	}

	[MenuItem("Herramientas/Probar Guardar Posicion Random")]
	private static void PosRandom()
	{
		PlayerPrefs.SetFloat ("posX", Random.value);
	}
}
