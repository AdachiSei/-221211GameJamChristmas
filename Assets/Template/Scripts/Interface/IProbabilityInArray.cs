
/// <summary>
/// SerializableやScriptableObjectに継承させてください
/// </summary>
/// <typeparam name="TScriptName">Scriptの名前</typeparam>
/// <typeparam name="T">値型</typeparam>
public interface IProbabilityInArray<TScriptName, T>
    where T : struct
    where TScriptName : IProbabilityInArray<TScriptName, T>
{
    public T[] AllValue(TScriptName num);
    //return num.T型.ToArray();
}
