using Cysharp.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 時間を管理するマネージャー
/// </summary>
public class TimeManager : SingletonMonoBehaviour<TimeManager>
{
    #region Public Property

    public float Timer => _timer;

    #endregion

    #region Inspector Member

    [SerializeField]
    [Header("タイマー")]
    private float _timer = 0f;

    #endregion

    #region Private Member

    private bool _isCounting;
    private bool _isPause;

    #endregion

    #region Unity Method

    protected override void Awake()
    {
        base.Awake();
        PauseManager.Instance.OnPause += Pause;
        PauseManager.Instance.OnResume+= Resume;
    }

    //private void Update()
    //{
    //    if (_isCounting)
    //    {
    //        _timer += Time.deltaTime;
    //    }
    //}

    private void OnDisable()
    {
        if(IsDontDestroy)
        {
            PauseManager.Instance.OnPause -= Pause;
            PauseManager.Instance.OnResume -= Resume;
        }
    }

    #endregion

    #region Public Methods

    public void StartTimer()
    {
        if (_isCounting) return;
        _isCounting = true;
        CountTimer();
    }

    public void StopTimer()
    {
        _isCounting = false;
    }

    public void Init()
    {
        _timer = 0;
    }

    #endregion

    #region Private Method

    async private void CountTimer()
    {
        while(_isCounting)
        {
            if (_isPause) await UniTask.WaitUntil(() => !_isPause);
            await UniTask.NextFrame();
            _timer += Time.deltaTime;
        }
    }

    #endregion

    #region 

    private void Pause()
    {
        _isPause = true;
    }

    private void Resume()
    {
        _isPause = false;
    }

    #endregion
}
